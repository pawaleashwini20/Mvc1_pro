using Microsoft.AspNetCore.Mvc;
using Mvc1_pro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc1_pro.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Stud_List()
        {
            List<Student> stud = new List<Student>()
          {
          new Student{ Id=101,Name="Siya",City="Pune",Marks=89},
          new Student{ Id=102,Name="Ashwini",City="Mumbai",Marks=99},
          new Student{ Id=103,Name="Swara",City="Delhi",Marks=78},
          new Student{ Id=104,Name="Riya",City="Chennai",Marks=76},
          new Student{ Id=105,Name="Radha",City="Pune",Marks=90},

          };
            ViewData["StudentList"] = stud;
            ViewBag.Student = stud;
            return View();
        }
    }
}
