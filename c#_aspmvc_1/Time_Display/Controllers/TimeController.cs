using Microsoft.AspNetCore.Mvc;
namespace Time_Display
{
    public class TimeController : Controller
    {
        [Route("")]
        [HttpGet]
        public ViewResult Time()
        {
            return View("Time");
        }
    }
}