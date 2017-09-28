using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AttitudeAviation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Welcome to Attitude Aviation!";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Wish to contact Attitude Aviation?";

            return View();
        }

        public IActionResult Rent()
        {
            ViewData["Message"] = "Schedule Rentals Online";

            return View();
        }

        public IActionResult Maintenance()
        {
            ViewData["Message"] = "Schedule Maintenance Online";

            return View();
        }

        public IActionResult Lessons()
        {
            ViewData["Message"] = "Schedule Flight Lessons Online";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
