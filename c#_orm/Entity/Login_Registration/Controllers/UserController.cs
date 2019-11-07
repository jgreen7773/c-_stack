using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Login_Registration.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace Login_Registration.Controllers
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
                    User LoggedEmail = NewUser;
                    HttpContext.Session.SetObjectAsJson("LoggedUserEmail", LoggedEmail);
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
                // Console.WriteLine("Line0----------------------------------------------------------------------------------------------------------------------------------------");
                PasswordHasher<LoginUser> LoginHasher = new PasswordHasher<LoginUser>();
                LoggingUser.LoginPassword = LoginHasher.HashPassword(LoggingUser, LoggingUser.LoginPassword);
                dbContext.LoginUser.Add(LoggingUser);
                dbContext.SaveChanges();
                User LoggedEmail = HttpContext.Session.GetObjectFromJson("LoggedUserEmail");
                LoginUser UserInDB = dbContext.LoginUser.FirstOrDefault(e => e.LoginEmail == LoggingUser.LoginEmail);
                if(UserInDB.LoginEmail == null)
                {
                    // Console.WriteLine("Line1----------------------------------------------------------------------------------------------------------------------------------------");
                    ModelState.AddModelError("Email", "Email or Password is Invalid!");
                    return View("Login");
                }
                var Hasher = new PasswordHasher<User>();
                if(Hasher.VerifyHashedPassword(LoggedEmail, UserInDB.LoginPassword, LoggedEmail.Password) == PasswordVerificationResult.Failed)
                {
                    // Console.WriteLine("Line2----------------------------------------------------------------------------------------------------------------------------------------");
                    ModelState.AddModelError("Password", "Email or Password is Invalid!");
                    return View("Login");
                }
                else
                {
                    // Console.WriteLine("Line3----------------------------------------------------------------------------------------------------------------------------------------");
                    string LoggedId = LoggingUser.LoginEmail;
                    HttpContext.Session.SetObjectAsJson("LoggedUserEmail", LoggedId);
                    // int? LoggedId = LoggingUser.UserId;
                    // HttpContext.Session.SetInt32("LoggedUser", Convert.ToInt32(LoggedId));
                    return RedirectToAction("Success");
                }
            }
            return View("Login");
        }
        // else if(LoggingUser.UserId != HttpContext.Session.GetInt32("LoggedUser"))

        [HttpGet]
        [Route("Success")]
        public IActionResult Success()
        {
            if(HttpContext.Session.GetInt32("LoggedUser") == null)
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