using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bank_Accounts.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Bank_Accounts.Controllers
{
    public class TransactionController : Controller
    {
        private MyContext dbContext;
        public TransactionController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet]
        [Route("Account")]
        public IActionResult DisplayUserAccount(decimal? Amount)
        {
            Console.WriteLine("Line----------------------------------------------------------------------------------------------------------------------------------------");
            // Attempt commenting out all the 'userid' uses and implement session users Id only
            dbContext.Users.Include(u => u.UsersTransactions).FirstOrDefault(u => u.UserId == HttpContext.Session.GetObjectFromJson("LoggedUserEmail").UserId);
            if(HttpContext.Session.GetObjectFromJson("LoggedUserEmail") == null)
            {
                // Console.WriteLine("Line1----------------------------------------------------------------------------------------------------------------------------------------");
                return Redirect("/Login");
            }
            else
            {
                Console.WriteLine("Line2----------------------------------------------------------------------------------------------------------------------------------------");
                User LoggedUser = dbContext.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetObjectFromJson("LoggedUserEmail").UserId);
                if (LoggedUser.UsersTransactions.Count == 0)
                {
                    // Console.WriteLine("Line3----------------------------------------------------------------------------------------------------------------------------------------");
                    Transaction InitializeAccount = new Transaction(){};
                    IEnumerable<Transaction> GetAccountTransactions = dbContext.Transactions.OrderBy(t => t.UserId == HttpContext.Session.GetObjectFromJson("LoggedUserEmail").UserId).ToList();
                    LoggedUser.UsersTransactions.Add(InitializeAccount);
                    dbContext.SaveChanges();
                    ViewBag.DisplayBalance = "Make a Deposit to Start Your Account.";
                    ViewBag.ListUsersTransactions = dbContext.Transactions.Where(t => t.UserId == HttpContext.Session.GetObjectFromJson("LoggedUserEmail").UserId);
                }
                else
                {
                    if (LoggedUser.UsersTransactions.Count == 0)
                    {
                        // Console.WriteLine("Line4----------------------------------------------------------------------------------------------------------------------------------------");
                        Transaction InitializeAccount = new Transaction(){
                            UserId = HttpContext.Session.GetObjectFromJson("LoggedUserEmail").UserId,
                            Amount = 327,
                        };
                        LoggedUser.UsersTransactions.Add(InitializeAccount);
                        dbContext.SaveChanges();
                        return RedirectToAction("DisplayUserAccount");
                    }
                    IEnumerable<Transaction> GetAccountTransactionsSum = dbContext.Transactions.Where(t => t.UserId == HttpContext.Session.GetObjectFromJson("LoggedUserEmail").UserId);
                    IEnumerable<Transaction> GetAccountTransactions = dbContext.Transactions.Where(t => t.UserId == HttpContext.Session.GetObjectFromJson("LoggedUserEmail").UserId).ToList();
                    List<decimal?> sum = new List<decimal?>(){};
                    foreach (var i in GetAccountTransactions)
                    {
                        sum.Add(i.Amount);
                    }
                    int AccountBalance = Convert.ToInt32(sum.Sum());
                    if (HttpContext.Session.GetInt32("CurrentUserTotalBalance") == 327)
                    {
                        HttpContext.Session.SetInt32("CurrentUserTotalBalance", AccountBalance);
                    }
                    ViewBag.DisplayBalance = AccountBalance;
                    dbContext.Users.Include(u => u.UsersTransactions).FirstOrDefault(u => u.UserId == HttpContext.Session.GetObjectFromJson("LoggedUserEmail").UserId);
                    ViewBag.ListUsersTransactions = dbContext.Transactions.Where(t => t.UserId == HttpContext.Session.GetObjectFromJson("LoggedUserEmail").UserId);
                }
                ViewBag.DisplayUser = LoggedUser.FirstName;
                return View("Account");
            }
        }

        [HttpPost]
        [Route("ProcessAccountTransaction")]
        public IActionResult ProcessTransaction(Transaction TransactionMade)
        {
            if (HttpContext.Session.GetObjectFromJson("LoggedUserEmail") == null)
            {
                // Console.WriteLine("Line1-----------------------------------------------------------------------------------------------------------------------------------------");
                return Redirect("/Login");
            }
            // Console.WriteLine("Line2----------------------------------------------------------------------------------------------------------------------------------------");
            // Console.WriteLine("Line3----------------------------------------------------------------------------------------------------------------------------------------");
            User LoggedUser = dbContext.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetObjectFromJson("LoggedUserEmail").UserId);
            // Console.WriteLine("LineBoolean----------------------------------------------------------------------------------------------------------------------------------");
            Transaction CurrentUserTransaction = dbContext.Transactions.FirstOrDefault(t => t.UserId == HttpContext.Session.GetObjectFromJson("LoggedUserEmail").UserId);
            // Console.WriteLine("Line4----------------------------------------------------------------------------------------------------------------------------------------");
            if (HttpContext.Session.GetInt32("CurrentUserTotalBalance") - TransactionMade.Amount < 0)
            {
                CurrentUserTransaction.Amount += Convert.ToInt32(TransactionMade.Amount);
                dbContext.Users.Include(u => u.UsersTransactions).FirstOrDefault(u => u.UserId == TransactionMade.UserId);
                LoggedUser.UsersTransactions.Add(TransactionMade);
                dbContext.SaveChanges();
                int changeSum = Convert.ToInt32(HttpContext.Session.GetInt32("CurrentUserTotalBalance"));
                changeSum += Convert.ToInt32(TransactionMade.Amount);
                HttpContext.Session.SetInt32("CurrentUserTotalBalance", changeSum);
                IEnumerable<Transaction> GetAccountTransactions = dbContext.Transactions.Where(t => t.UserId == HttpContext.Session.GetObjectFromJson("LoggedUserEmail").UserId);
                ViewBag.DisplayBalance = HttpContext.Session.GetInt32("CurrentUserTotalBalance");
                ViewBag.ListUsersTransactions = dbContext.Transactions.Where(t => t.UserId == HttpContext.Session.GetObjectFromJson("LoggedUserEmail").UserId);
                ViewBag.DisplayUser = LoggedUser.FirstName;
                return Redirect("/Account");
            }
            else if (HttpContext.Session.GetInt32("CurrentUserTotalBalance") - TransactionMade.Amount == 0)
            {
                CurrentUserTransaction.Amount += Convert.ToInt32(TransactionMade.Amount);
                dbContext.Users.Include(u => u.UsersTransactions).FirstOrDefault(u => u.UserId == TransactionMade.UserId);
                LoggedUser.UsersTransactions.Add(TransactionMade);
                dbContext.SaveChanges();
                int changeSum = Convert.ToInt32(HttpContext.Session.GetInt32("CurrentUserTotalBalance"));
                changeSum += Convert.ToInt32(TransactionMade.Amount);
                HttpContext.Session.SetInt32("CurrentUserTotalBalance", changeSum);
                IEnumerable<Transaction> GetAccountTransactions = dbContext.Transactions.Where(t => t.UserId == HttpContext.Session.GetObjectFromJson("LoggedUserEmail").UserId);
                // ViewBag.DisplayBalance = CurrentUserTransaction.Amount;
                // Transaction DisplayUpdatedBalance = dbContext.Transactions.FirstOrDefault(t => t.Amount == HttpContext.Session.GetInt32("CompareBalance"));
                // dbContext.Transactions.FirstOrDefault(t => t.UserId == HttpContext.Session.GetObjectFromJson("LoggedUserEmail").UserId));
                ViewBag.DisplayBalance = HttpContext.Session.GetInt32("CurrentUserTotalBalance");
                ViewBag.ListUsersTransactions = dbContext.Transactions.Where(t => t.UserId == HttpContext.Session.GetObjectFromJson("LoggedUserEmail").UserId);
                ViewBag.DisplayUser = LoggedUser.FirstName;
                return Redirect("/Account");
            }
            else
            {
                // Console.WriteLine("Line5----------------------------------------------------------------------------------------------------------------------------------------");
                ViewBag.InsufficientAmount = "You have insufficient money in your account.";
                ViewBag.DisplayBalance = HttpContext.Session.GetInt32("CurrentUserTotalBalance");
                ViewBag.ListUsersTransactions = dbContext.Transactions.Where(t => t.UserId == HttpContext.Session.GetObjectFromJson("LoggedUserEmail").UserId);
                ViewBag.DisplayUser = LoggedUser.FirstName;
                return View("Account");
            }
        }
    }
}