using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc1_pro.Models
{
    public class Student
    {
        public int Id
        {
            get;
            set;
        }
        public String Name { get; set; }
        public String City { get; set; }
        public int Marks { get; set; }
    }
}
