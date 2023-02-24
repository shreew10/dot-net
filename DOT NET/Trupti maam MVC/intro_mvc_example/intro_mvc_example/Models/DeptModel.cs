using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace intro_mvc_example.Models
{
    public class DeptModel
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public double DeptContact { get; set; }
        public string DeptDate { get; set; }
    }
}