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
    // public static class SessionExtensions
    // {
    //     public static void SetObjectAsJson(this ISession session, string key, object value)
    //     {
    //         session.SetString(key, JsonConvert.SerializeObject(value));
    //     }
    //     public static User GetObjectFromJson(this ISession session, string key)
    //     {
    //         string value = session.GetString(key);
    //         return value == null ? default(User) : JsonConvert.DeserializeObject<User>(value);
    //     }
    // }
    public class ProductController : Controller
    {

        private MyContext dbContext;
        public ProductController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet]
        [Route("")]
        public IActionResult RedirectRoute()
        {
            return Redirect("/products");
        }

        [HttpGet]
        [Route("products")]
        public IActionResult Products(int ProductId)
        {
            // Does this command below populate values or objects? (pretty sure it is objects)
            // dbContext.Products.Include(p => p.CategoryOfProduct).ThenInclude(a => a.CategoryDefinition).FirstOrDefault(p => p.ProductId == ProductId);
            ViewBag.AllProductsList = dbContext.Products.OrderBy(p => p.ProductName).ToList();
            return View();
        }

        [HttpGet]
        [Route("products/{ProductId}")]
        public IActionResult ViewProduct(int ProductId)
        {
            // from product, retrieve categories related to products
            Product RetrievedProduct = dbContext.Products.Include(p => p.CategoryOfProduct).ThenInclude(a => a.CategoryDefinition).FirstOrDefault(p => p.ProductId == ProductId);
            List<Category> CompareCategories = dbContext.Categories.Include(c => c.ProductInCategory).ThenInclude(a => a.CategoryDefinition).ToList();
            List<Category> CategoriesRelatedToProduct = new List<Category>();
            foreach (var i in CompareCategories)
            {
                if(i.ProductInCategory.Any(p => p.ProductId == ProductId))
                {
                    CategoriesRelatedToProduct.Add(i);
                }
            }
            // reach values and populate into database PRODUCT list related to that category (make sure they are values)
            ViewBag.CategoryOfProduct = CategoriesRelatedToProduct;
            ViewBag.AllCategoriesList = dbContext.Categories.ToList();
            ViewBag.DisplayProduct = RetrievedProduct;
            ViewBag.DisplayProductName = dbContext.Products.FirstOrDefault(p => p.ProductId == ProductId).ProductName;
            return View();
        }





        [HttpPost]
        [Route("addnewproduct")]
        public IActionResult AddNewProduct(Product CreateProduct)
        {
            dbContext.Products.Add(CreateProduct);
            dbContext.SaveChanges();
            return Redirect("products");
        }

        [HttpPost]
        [Route("addproductcategory/{ProductId}")]
        public IActionResult AddCategoryToProduct(Association Connect, int ProductId)
        {
            Connect.ProductId = ProductId;
            dbContext.Associations.Add(Connect);
            dbContext.SaveChanges();
            return RedirectToAction("products", new {ProductId = ProductId});
        }
    }
}