using Microsoft.AspNetCore.Mvc;
using Mvc1_pro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc1_pro.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Emp_List()
        {
            List<Employee> emp = new List<Employee>()
          {
             new Employee{ Id=111,Name="AAA",Address="Pune",Salary=89000},
             new Employee{ Id=112,Name="LLL",Address="Mumbai",Salary=87000},
             new Employee{ Id=113,Name="MMM",Address="Delhi",Salary=34000},
             new Employee{ Id=114,Name="BBB",Address="Pune",Salary=123000},


          };
            ViewData["EmployeeList"]=emp;
            ViewBag.Employee =emp;
            return View();
        }
    }
}
