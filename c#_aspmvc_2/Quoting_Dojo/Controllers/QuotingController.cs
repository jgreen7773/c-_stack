using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Quoting_Dojo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Quoting_Dojo;

namespace Quoting_Dojo.Controllers
{
    public class QuotingController : Controller
    {
        private MyContext dbContext;
        public QuotingController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet]
        [Route("")]
        public IActionResult AddQuotes(Quoting NewQuote)
        {
            // List<Dictionary<string, object>> AllQuotes = DbConnecter.Query("SELECT * FROM Quoting");
            // ViewBag.ListQuotes = AllQuotes;
            dbContext.Add(NewQuote);
            dbContext.SaveChanges();
            return View();
        }

        [HttpPost]
        [Route("processing")]
        public IActionResult Processing(string name, string quote)
        {
            
            string queryString = $"INSERT INTO Quoting (Name, Quote) VALUES ('{name}', '{quote}')";
            DbConnector.Execute(queryString);
            return Redirect("/");
        }

        [HttpGet]
        [Route("quotes")]
        public IActionResult Quotes()
        {
            // Dictionary<string, object> Quote = DbConnector.Query($"SELECT * FROM users WHERE id = {1}")[0];
            List<Quoting> AllQuotes = dbContext.Quotings.ToList();
            return View(AllQuotes);
        }
    }
}