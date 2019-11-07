using Microsoft.AspNetCore.Mvc;
namespace Portfolio
{
    public class PortfolioController : Controller
    {
        [Route("")]
        [HttpGet]
        public ViewResult Portfolio()
        {
            return View("Portfolio");
        }

        [Route("projects")]
        [HttpGet]
        public ViewResult Projects()
        {
            return View("Projects");
        }

        [Route("contactme")]
        [HttpGet]
        public ViewResult ContactMe()
        {
            return View("ContactMe");
        }
    }
}