
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc1_pro.Controllers
{
    public class FoodController : Controller
    {
        [HttpGet]

        public IActionResult FoodMenu()
        {
            List<String> option = new List<String>() { "select option", "Veg", "Non veg" };
            ViewData["option"] = new SelectList(option);

            return View();
        }
        [HttpPost]
          public IActionResult FoodMenu(IFormCollection form,ICollection<String>food)
          {
              ViewBag.Name = form["fname"];
              ViewBag.Contact = form["contact"];
              ViewBag.FoodOrder = food;
              ViewBag.Option = form["option"];
              return View("FoodDetails");
          }
    
    }
}
