using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Dojo_Survey.Models;
namespace Dojo_Survey
{
    public class SurveyController : Controller
    {

        [HttpGet]
        [Route("")]
        public ViewResult RequestSurvey()
        {
            return View("RequestSurvey");
        }
        
        [HttpPost]
        [Route("displaysurvey")]
        public IActionResult DisplaySurvey(string name, string location, string language, string comments)
        {
            List<SurveyUser> users = new List<SurveyUser>();
            // users.Add(new SurveyUser(){
            //     Name = "Jambo",
            //     Location = "Seattle",
            //     Language = "ReactJS",
            //     Comments = "This is my comment",
            // });
            users.Add(new SurveyUser(){
                Name = name,
                Location = location,
                Language = language,
                Comments = comments,
            });
            // SurveyUser newuser = new SurveyUser() {
            //     Name = name,
            //     Location = location,
            //     Language = language,
            //     Comments = comments,
            // };
            // ViewBag.displayname = name;
            // ViewBag.displaylocation = location;
            // ViewBag.displaylanguage = language;
            // ViewBag.displaycomments = comments;
            return View("DisplaySurvey", users);
        }
    }
}