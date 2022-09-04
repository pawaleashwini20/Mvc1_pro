   using Microsoft.AspNetCore.Mvc;
using Mvc1_pro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc1_pro.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            List<Product> product = new List<Product>()
            {
                new Product{ Id=1,Name="Dell Laptop",Price=12344},
                 new Product{ Id=2,Name="Lenovo Laptop",Price=44344},
                  new Product{ Id=3,Name="HP Laptop",Price=2223},
                   new Product{ Id=4,Name="Dell Mouse",Price=1234},
            };
            ViewData["productlist"] = product;
            ViewBag.Products = product;

            return View();
        }
    }
}
