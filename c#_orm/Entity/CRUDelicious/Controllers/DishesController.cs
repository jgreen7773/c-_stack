using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Controllers
{
    public class DishesController : Controller
    {
        private MyContext dbContext;
        public DishesController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet]
        [Route("")]
        public IActionResult CRUDelicious(Dishes importDishes)
        {
            List<Dishes> allDishes = dbContext.Dishes.ToList();
            // IEnumerable<Dishes> allDishes1 = allDishes.Where(p => p.DishId > 0);
            return View("CRUDelicious", allDishes);
        }

        [HttpGet]
        [Route("AddDish")]
        public IActionResult AddDish()
        {
            return View("AddDish");
        }

        [HttpPost]
        [Route("AddingDish")]
        public IActionResult AddingDish(Dishes NewDish)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(NewDish);
                dbContext.SaveChanges();
                return RedirectToAction("CRUDelicious", NewDish);
            }
            return View("AddDish");
        }

        [HttpGet]
        [Route("MyDish/{dishId}")]
        public IActionResult MyDish(int dishId)
        {
            Dishes OneDish = dbContext.Dishes.FirstOrDefault(d => d.DishId == dishId);
            return View(OneDish);
        }

        [HttpGet]
        [Route("EditDish/{dishId}")]
        public IActionResult EditDish(int dishId)
        {
            Dishes OneDish = dbContext.Dishes.FirstOrDefault(d => d.DishId == dishId);
            return View(OneDish);
        }

        [HttpPost]
        [Route("EditingDish/{dishId}")]
        public IActionResult EditingDish(int dishId, Dishes EditDish)
        {   
            System.Console.WriteLine($"##############{EditDish.Description}");
            // Dishes OneDish = dbContext.Dishes.FirstOrDefault(d => d.DishId == dishId);
            if(ModelState.IsValid)
            {
                Dishes DishToEdit = dbContext.Dishes.FirstOrDefault(d => d.DishId == dishId);
                DishToEdit.Chef = EditDish.Chef;
                DishToEdit.Name = EditDish.Name;
                DishToEdit.Calories = EditDish.Calories;
                DishToEdit.Tastiness = EditDish.Tastiness;
                DishToEdit.Description = EditDish.Description;
                DishToEdit.UpdatedAt = DateTime.Now;
                dbContext.SaveChanges();
                return RedirectToAction("CRUDelicious");
            }
            else
            {
                return View($"EditDish/{dishId}");
            }
        }

        [HttpPost]
        [Route("Delete/{dishId}")]
        public IActionResult Delete(int dishId)
        {
            Dishes DishToDelete = dbContext.Dishes.FirstOrDefault(d => d.DishId == dishId);
            dbContext.Dishes.Remove(DishToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("CRUDelicious");
        }
    }
}