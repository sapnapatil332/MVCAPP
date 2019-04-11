using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAPP.Models
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }
        public string Salary { get; set; }
        public string Address { get; set; }
    }
}