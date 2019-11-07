using Microsoft.AspNetCore.Mvc;
namespace Razor_Fun
{
    public class RazorController : Controller
    {
        [Route("")]
        [HttpGet]
        public ViewResult Razor()
        {
            return View("Razor");
        }
    }
}