using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using validate_form_submit.Models;

namespace validate_form_submit.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Success()
        {
            return View();
        }

        public IActionResult Privacy(User NewUser, string fname, string lname, int age, string email, string password, string cpassword)
        {
            if(ModelState.IsValid)
            {
                User addinguser = new User(){
                    Fname = fname,
                    Lname = lname,
                    Age = age,
                    Email = email,
                    Password = password,
                    CPassword = cpassword,
                };
                return Redirect("Success");
            }
            else
            {
                // put something here?
                return View("Index");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
