using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dojodachi.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace dojodachi.Controllers
{
    public class DachiController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Dachi(int Happiness, int Fullness, int Energy, int Meals)
        {
            Dachi tamagotchi = new Dachi();
            HttpContext.Session.SetObjectAsJson("gotchi", tamagotchi);
            Dachi moddachi = HttpContext.Session.GetObjectFromJson<Dachi>("gotchi");
            if (moddachi.Happiness == 20)
            {
            // IsAlive(energy, fullness, happiness, meals);
            // IsWin(energy, fullness, happiness, meals);
            // Either serialize the object instance of "Dachi", or use int/string
            // Also, instantiate the object "Dachi"
                HttpContext.Session.SetInt32("happinesslevel", moddachi.Happiness);
                HttpContext.Session.SetInt32("fullnesslevel", moddachi.Fullness);
                HttpContext.Session.SetInt32("energylevel", moddachi.Energy);
                HttpContext.Session.SetInt32("mealslevel", moddachi.Meals);
                return View(moddachi);
            }
            return View(tamagotchi);
        }

        [HttpPost]
        [Route("/playdachi")]
        public IActionResult PlayDachi(int energy, int fullness, int happiness, int meals, object Play)
        {
            Dachi moddachi = HttpContext.Session.GetObjectFromJson<Dachi>("gotchi");
            int modenergy = Convert.ToInt32(HttpContext.Session.GetInt32("energylevel"));
            int modhappiness = Convert.ToInt32(HttpContext.Session.GetInt32("happinesslevel"));
            moddachi.Play(modenergy, modhappiness);
            HttpContext.Session.SetInt32("energylevel", modenergy);
            HttpContext.Session.SetInt32("happinesslevel", modhappiness);
            HttpContext.Session.SetObjectAsJson("gotchi", moddachi);
            // moddachi.Happiness = happiness;
            // moddachi.Energy = energy;
            return Redirect("/");
        }

        [HttpPost]
        [Route("/feeddachi")]
        public IActionResult FeedDachi(int energy, int fullness, int happiness, int meals, object Feed)
        {
            Dachi moddachi = HttpContext.Session.GetObjectFromJson<Dachi>("gotchi");
            int modmeals = Convert.ToInt32(HttpContext.Session.GetInt32("mealslevel"));
            int modfullness = Convert.ToInt32(HttpContext.Session.GetInt32("fullnesslevel"));
            moddachi.Feed(modmeals, modfullness);
            HttpContext.Session.SetInt32("mealslevel", modmeals);
            HttpContext.Session.SetInt32("fullnesslevel", modfullness);
            HttpContext.Session.SetObjectAsJson("gotchi", moddachi);
            // moddachi.Meals = meals;
            // moddachi.Fullness = fullness;
            return Redirect("/");
        }

        [HttpPost]
        [Route("/workdachi")]
        public IActionResult WorkDachi(int energy, int fullness, int happiness, int meals, object Work)
        {
            Dachi moddachi = HttpContext.Session.GetObjectFromJson<Dachi>("gotchi");
            int modenergy = Convert.ToInt32(HttpContext.Session.GetInt32("energylevel"));
            int modmeals = Convert.ToInt32(HttpContext.Session.GetInt32("mealslevel"));
            moddachi.Work(modenergy, modmeals);
            HttpContext.Session.SetInt32("energylevel", modenergy);
            HttpContext.Session.SetInt32("mealslevel", modmeals);
            HttpContext.Session.SetObjectAsJson("gotchi", moddachi);
            // moddachi.Energy = energy;
            // moddachi.Meals = meals;
            return Redirect("/");
        }

        [HttpPost]
        [Route("/sleepdachi")]
        public IActionResult SleepDachi(int energy, int fullness, int happiness, int meals, object Sleep)
        {
            Dachi moddachi = HttpContext.Session.GetObjectFromJson<Dachi>("gotchi");
            int modenergy = Convert.ToInt32(HttpContext.Session.GetInt32("energylevel"));
            int modhappiness = Convert.ToInt32(HttpContext.Session.GetInt32("happinesslevel"));
            int modfullness = Convert.ToInt32(HttpContext.Session.GetInt32("fullnesslevel"));
            moddachi.Sleep(modenergy, modhappiness, modfullness);
            HttpContext.Session.SetInt32("energylevel", modenergy);
            HttpContext.Session.SetInt32("happinesslevel", modhappiness);
            HttpContext.Session.SetInt32("fullnesslevel", modfullness);
            HttpContext.Session.SetObjectAsJson("gotchi", moddachi);
            // moddachi.Energy = energy;
            // moddachi.Happiness = happiness;
            // moddachi.Fullness = fullness;
            return Redirect("/");
        }

        [HttpPost]
        [Route("/resetdachi")]
        public IActionResult ResetDachi(int energy, int fullness, int happiness, object Restart)
        {
            HttpContext.Session.Clear();
            return Redirect("/");
        }
    }
}