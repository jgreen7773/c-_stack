using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Products_Categories.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace Products_Categories.Controllers
{
    public class CategoryController : Controller
    {
        
        private MyContext dbContext;
        public CategoryController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet]
        [Route("categories")]
        public IActionResult Categories(int CategoryId)
        {
            ViewBag.AllCategoriesList = dbContext.Categories.OrderBy(p => p.CategoryName).ToList();
            return View();
        }

        [HttpGet]
        [Route("categories/{CategoryId}")]
        public IActionResult ViewCategory(List<Association> CategoryOfProduct, int CategoryId)
        {
            // Retrieve Category from database while populating fields into the list
            Category RetrievedCategory = dbContext.Categories.Include(a => a.ProductInCategory).ThenInclude(a => a.ProductDefinition).FirstOrDefault(c => c.CategoryId == CategoryId);
            // Retrieve all products to later compare the products related to this viewed category
            List<Product> CompareProducts = dbContext.Products.Include(p => p.CategoryOfProduct).ThenInclude(a => a.ProductDefinition).ToList();

            // from category, retrieve products related to category with a new List to view, or is the query able to be made through association table?
            List<Product> ProductsRelatedToCategory = new List<Product>();
            // foreach loop to Add to list while looping
            foreach (var i in CompareProducts)
            {
                if (i.CategoryOfProduct.Any(c => c.CategoryId == RetrievedCategory.CategoryId))
                {
                    ProductsRelatedToCategory.Add(i);
                }
            }
            // reach values and populate into database PRODUCT list related to that category (make sure they are values)
            ViewBag.ProductInCategory = ProductsRelatedToCategory;
            ViewBag.AllProductsList = dbContext.Products.ToList();
            ViewBag.DisplayCategory = RetrievedCategory;
            ViewBag.DisplayCategoryName = dbContext.Categories.FirstOrDefault(c => c.CategoryId == CategoryId).CategoryName;
            return View();
        }





        [HttpPost]
        [Route("addnewcategory")]
        public IActionResult AddNewCategory(Category CreateCategory)
        {
            dbContext.Categories.Add(CreateCategory);
            dbContext.SaveChanges();
            return Redirect("categories");
        }

        [HttpPost]
        [Route("addcategoryproduct/{CategoryId}")]
        public IActionResult AddProductToCategory(Association Connect, int CategoryId)
        {
            Connect.CategoryId = CategoryId;
            dbContext.Associations.Add(Connect);
            dbContext.SaveChanges();
            return RedirectToAction("categories", new {CategoryId = CategoryId});
        }
    }
}