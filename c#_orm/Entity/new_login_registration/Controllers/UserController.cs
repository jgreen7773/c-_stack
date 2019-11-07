using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using new_login_registration.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace new_login_registration.Controllers
{
    public static class SessionExtensions
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        public static User GetObjectFromJson(this ISession session, string key)
        {
            string value = session.GetString(key);
            return value == null ? default(User) : JsonConvert.DeserializeObject<User>(value);
        }
    }
    public class UserController : Controller
    {
        private MyContext dbContext;
        public UserController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        [Route("ProcessingRegistration")]
        public IActionResult ProcessRegistration(User NewUser)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(e => e.Email == NewUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Registration");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    NewUser.Password = Hasher.HashPassword(NewUser, NewUser.Password);
                    dbContext.Users.Add(NewUser);
                    dbContext.SaveChanges();
                    return Redirect("/Login");
                }
            }
            return View("Registration");
        }

        [HttpGet]
        [Route("Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("ProcessingLogin")]
        public IActionResult ProcessLogin(LoginUser LoggingUser)
        {
            // Console.WriteLine("Line----------------------------------------------------------------------------------------------------------------------------------------");
            if(ModelState.IsValid)
            {
                User UserInDB = dbContext.Users.FirstOrDefault(e => e.Email == LoggingUser.LoginEmail);
                // Console.WriteLine("Line0----------------------------------------------------------------------------------------------------------------------------------------");
                var LoginHasher = new PasswordHasher<LoginUser>();

                if(UserInDB == null)
                {
                    // Console.WriteLine("Line1----------------------------------------------------------------------------------------------------------------------------------------");
                    ModelState.AddModelError("LoginEmail", "Email or Password is Invalid!");
                    return View("Login");
                }
                else if(LoginHasher.VerifyHashedPassword(LoggingUser, UserInDB.Password, LoggingUser.LoginPassword) == PasswordVerificationResult.Success)
                {
                    // Console.WriteLine("Line2----------------------------------------------------------------------------------------------------------------------------------------");
                    User LoggedId = UserInDB;
                    HttpContext.Session.SetObjectAsJson("LoggedUserEmail", LoggedId);
                    return RedirectToAction("Success");
                }
                else
                {
                    // Console.WriteLine("Line3----------------------------------------------------------------------------------------------------------------------------------------");
                    ModelState.AddModelError("LoginEmail", "Email or Password is Invalid!");
                    return View("Login");
                }
            }
            // Console.WriteLine("Line4----------------------------------------------------------------------------------------------------------------------------------------");
            return View("Login");
        }

        [HttpGet]
        [Route("Success")]
        public IActionResult Success()
        {
            if(HttpContext.Session.GetObjectFromJson("LoggedUserEmail") == null)
            {
                return Redirect("/Login");
            }
            return View();
        }

        [HttpPost]
        [Route("LoggingOut")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Login");
        }
    }
}