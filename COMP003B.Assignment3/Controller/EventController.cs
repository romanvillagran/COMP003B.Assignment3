using Microsoft.AspNetCore.Mvc;
using COMP003B.Assignment3.Models;

namespace COMP003B.Assignment3.Controllers
{
    public class EventController : Controller
    {
        [HttpGet("event/register/{eventCode}")]
        public IActionResult Register(string eventCode)
        {
            return View(new EventRegistration { EventCode = eventCode });
        }


    }
}
