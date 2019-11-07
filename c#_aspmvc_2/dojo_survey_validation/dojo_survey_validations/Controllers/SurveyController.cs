using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using dojo_survey_validations.Models;
namespace dojo_survey_validations.Models
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
        [Route("DisplaySurvey")]
        public IActionResult DisplaySurvey(SurveyUser NewUser, string name, string location, string language, string comments)
        {
            if(ModelState.IsValid)
            {
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
                return View("DisplaySurvey", users);
            }
            else
            {
                return View("RequestSurvey");
            }
        }
    }
}