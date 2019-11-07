using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Chefs_N_Dishes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Chefs_N_Dishes.Controllers
{
    public class ChefController : Controller
    {
        private MyContext dbContext;
        public ChefController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Redirect()
        {
            return Redirect("/AllChefs");
        }

        [HttpGet]
        [Route("AllChefs")]
        public IActionResult AllChefs(Chef ChefObject)
        {
            // List<Dish> ListDishes = dbContext.Chefs.Include(c => c.ChefId).Where(l => l.ChefId == DishObject.ChefId).ToList();
            // Chef OneChef = dbContext.Chefs.FirstOrDefault(c => c.ChefId == ChefId);
            List<Chef> ListChefsDishes = dbContext.Chefs.Include(c => c.ListDishes).ToList();
            // int ListCount = OneChef.ListDishes.Count();
            // ViewBag.Count = ListCount;
            // IEnumerable<Chef> ListAllChefs = dbContext.Chefs.Where(c => c.ChefId == ChefObject.ChefId).ToList();
            // IEnumerable<Dish> ListAllDishes = dbContext.Dishes.Where(d => d.DishId == DishId);
            // IEnumerable<Chef> ChefsDishCount = dbContext.Chefs.Include(d => d.List<Dish> ListDishes).Where(c => c.ListDishes).ToList();
            // List<Dish> ChefsDishCount = dbContext.Dishes.Include(d => d.ChefId).Where(c => c.ChefId == OneChef.ChefId).ToList();
            return View("AllChefs", ListChefsDishes);
            // , ListAllChefs
        }

        [HttpGet]
        [Route("AddChef")]
        public IActionResult AddChefs()
        {
            return View("AddChef");
        }




        [HttpPost]
        [Route("AddingChef")]
        public IActionResult AddingChef(Chef AddNewChef)
        {
            // if(IsDate(AddNewChef.BirthDate) == false)
            if (ModelState.IsValid)
            {
                dbContext.Chefs.Add(AddNewChef);
                dbContext.SaveChanges();
                return RedirectToAction("AllChefs");
            }
            return View("AddChef");
        }
    }
}