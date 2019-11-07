using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Random_Passcode.Models;
using Microsoft.AspNetCore.Http;

namespace Random_Passcode.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("count") < 1)
            {
                HttpContext.Session.SetInt32("count", 0);
            }
            return View();
        }

        [HttpPost]
        [Route("/gen")]
        public IActionResult Privacy()
        {
            int num = Convert.ToInt32(HttpContext.Session.GetInt32("count"));
            num++;
            HttpContext.Session.SetInt32("count", num);
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] generateString = new char[14];
            Random randNum = new Random();
            for (int i = 0; i < generateString.Length; i++)
            {
                generateString[i] = chars[randNum.Next(chars.Length)];
            }
            ViewBag.Count = num;
            ViewBag.Number = new String(generateString);
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
