using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mvc1_pro.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc1_pro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Message = "This is simple MVC Application";
            List<String> colorList = new List<string>()
            {
                "Blue","Red","Green","Pink","Yellow","Gray","White","Black"

            };
             ViewData["message"] = "This is my First MVC Page...";
            ViewData["Experience"] = "I Have 2 Years Experience";
            ViewData["Year"] = 2022;
            ViewData["list"] = colorList;
            ViewBag.ColorList = colorList;


            return View();
        }

        public IActionResult aboutus()
        {
            return View();
        }

        public IActionResult contactus()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
