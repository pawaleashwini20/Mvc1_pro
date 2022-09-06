using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc1_pro.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult PersonalDetails()
        {
            List<String> options = new List<string>() { "select option","yes","no"};
            ViewData["options"] = new SelectList(options);
            return View();
        }
        [HttpPost]
        public IActionResult PersonalDetails(IFormCollection form)
        {
            ViewBag.Name = form["fname"];
            ViewBag.Contact = form["contact"];
            ViewBag.Gender = form["gender"];
            ViewBag.Hobbies =form["hobbies"];
            ViewBag.Option = form["options"];
            return View("Details");
        }
    }
}
