using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wedding_Planner.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace Wedding_Planner.Controllers
{
    public class WeddingController : Controller
    {
        private MyContext dbContext;
        public WeddingController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet]
        [Route("Dashboard")]
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetObjectFromJson("LoggedUserEmail") == null)
            {
                return Redirect("/Login");
            }
            int LoggedUserId = HttpContext.Session.GetObjectFromJson("LoggedUserEmail").UserId;
            List<Wedding> AllWeddings = dbContext.Weddings.Include(w => w.GuestsAttending).ThenInclude(a => a.AGuest).ToList();
            User Users = dbContext.Users.Include(u => u.WeddingsAttending).ThenInclude(a => a.AWedding).FirstOrDefault(u => u.UserId != LoggedUserId);
            List<Association> AllAssociations = dbContext.Associations.Include(a => a.AGuest).ThenInclude(u => u.WeddingsAttending).Include(a => a.AWedding).ThenInclude(w => w.GuestsAttending).ToList();
            List<Wedding> GuestList = new List<Wedding>();
            // List<User> AttendeeList = new List<User>();
            foreach (Wedding guest in AllWeddings)
            {
                if (LoggedUserId != guest.UserId)
                {
                    GuestList.Add(guest);
                }
            }
            ViewBag.LoggedUserId = LoggedUserId;
            ViewBag.AllWeddings = AllWeddings;
            // ViewBag.AllUsers = AllUsers;
            ViewBag.AllAssociations = AllAssociations;
            // ViewBag.GuestList = GuestList;
            ViewBag.AttendeeList = GuestList;
            return View(AllWeddings);
        }

        [HttpGet]
        [Route("PlanWedding")]
        public IActionResult PlanWedding()
        {
            if (HttpContext.Session.GetObjectFromJson("LoggedUserEmail") == null)
            {
                return Redirect("/Login");
            }
            return View();
        }

        [HttpGet]
        [Route("ViewWedding/{WeddingId}")]
        public IActionResult ViewWedding(int WeddingId)
        {
            if (HttpContext.Session.GetObjectFromJson("LoggedUserEmail") == null)
            {
                return Redirect("/Login");
            }
            Wedding ThisWedding = dbContext.Weddings.Include(w => w.GuestsAttending).ThenInclude(a => a.AGuest).FirstOrDefault(w => w.WeddingId == WeddingId);
            return View(ThisWedding);
        }



        [HttpPost]
        [Route("ProcessPlanWedding")]
        public IActionResult ProcessPlanWedding(Wedding NewWedding)
        {
            if (HttpContext.Session.GetObjectFromJson("LoggedUserEmail") == null)
            {
                return Redirect("/Login");
            }
            NewWedding.UserId = HttpContext.Session.GetObjectFromJson("LoggedUserEmail").UserId;
            if (ModelState.IsValid)
            {
                dbContext.Add(NewWedding);
                dbContext.SaveChanges();
                return Redirect($"/ViewWedding/{NewWedding.WeddingId}");
            }
            else
            {
                return View("PlanWedding");
            }
        }

        [HttpGet]
        [Route("ProcessJoinWedding/{WeddingId}")]
        public IActionResult ProcessJoinWedding(int WeddingId)
        {
            if (HttpContext.Session.GetObjectFromJson("LoggedUserEmail") == null)
            {
                return Redirect("/Login");
            }
            User LoggedUser = HttpContext.Session.GetObjectFromJson("LoggedUserEmail");
            Association NewGuest = new Association();
            NewGuest.UserId = LoggedUser.UserId;
            NewGuest.WeddingId = WeddingId;
            dbContext.Add(NewGuest);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet]
        [Route("ProcessLeaveWedding/{WeddingId}")]
        public IActionResult ProcessLeaveWedding(int WeddingId)
        {
            if (HttpContext.Session.GetObjectFromJson("LoggedUserEmail") == null)
            {
                return Redirect("/Login");
            }
            Association Retrieve = dbContext.Associations.FirstOrDefault(a => a.WeddingId == WeddingId);
            dbContext.Associations.Remove(Retrieve);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet]
        [Route("Delete/{WeddingId}")]
        public IActionResult Delete(int WeddingId)
        {
            if (HttpContext.Session.GetObjectFromJson("LoggedUserEmail") == null)
            {
                return Redirect("/Login");
            }
            int? LoggedUser = HttpContext.Session.GetObjectFromJson("LoggedUserEmail").UserId;
            Wedding DeleteWedding = dbContext.Weddings.FirstOrDefault(w => w.WeddingId == WeddingId);
            if (LoggedUser == DeleteWedding.UserId)
            {
                dbContext.Weddings.Remove(DeleteWedding);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            else
            {
                return RedirectToAction("Dashboard");
            }
        }
    }
}