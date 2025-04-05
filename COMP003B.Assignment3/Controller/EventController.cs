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

        [HttpGet("Event/Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("Event/Register")]
        public IActionResult Register(EventRegistration registration)
        {
            if (!ModelState.IsValid) 
            {
                return View(registration);
            }

            TempData["Registration"] = $"Thanks {registration.FullName} for {registration.Tickets} tickets!";
            return RedirectToAction("Success");
        }

        [HttpGet("Event/Success")]
        public IActionResult Success()
        {
            return View();
        }
    }
}
