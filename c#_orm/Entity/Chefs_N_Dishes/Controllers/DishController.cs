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
    public class DishController : Controller
    {
        private MyContext dbContext;
        public DishController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet]
        [Route("AllDishes")]
        public IActionResult AllDishes(int DishId)
        {
            List<Dish> ListAllDishes = dbContext.Dishes.ToList();
            // IEnumerable<Dish> ListAllDishes = dbContext.Dishes.Include(c => c.Chef).Where(d => d.DishId == DishId).ToList();
            // IEnumerable<Dish> ListAllDishes = dbContext.Dishes.Include(d => d.ListDishes).ToList();
            return View("AllDishes", ListAllDishes);
        }

        [HttpGet]
        [Route("AddDish")]
        public IActionResult AddDish()
        {
            List<Chef> ListAllChefs = dbContext.Chefs.ToList();
            ViewBag.ListChefs = ListAllChefs;
            return View("AddDish");
        }




        [HttpPost]
        [Route("AddingDish")]
        public IActionResult AddingDish(Dish AddNewDish)
        {
            // pull List from Database, Instatiate/populate as dish is made, connect to ChefId
            // dbContext.Dishes.Chef.Add() add connection (first/last name) to Chef attribute of type dish
            // IEnumerable<Dish> AddDishToChefsRecipeList = dbContext.Chefs.Include(l => l.ListDishes).FirstOrDefault(c => c.ChefId == AddNewDish.ChefId);

            // dbContext.Dishes.FirstOrDefault(c => c.ChefId == AddNewDish.ChefId));
            // ListDishes.Add(AddNewDish);
            // add Dish to list of 'dishes created by Chef'
            // dbContext.Chefs.Include(d => d.ListDishes)
            // Console.WriteLine("1---------------------------------------------------------------------------------------------------");
            dbContext.Add(AddNewDish);
            // Console.WriteLine("2---------------------------------------------------------------------------------------------------");
            dbContext.SaveChanges();
            // Console.WriteLine("3---------------------------------------------------------------------------------------------------");
            return RedirectToAction("AllDishes");
        }
    }
}