using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace intro_mvc_example.Models
{
    public class EmpBL
    {
        public Emp funEmp()
        {
            Emp obj = new Emp()
            {
                ID = 1,
                Name = "trupti",
                Address = "Chiplun",
                Email = "trupti@gmail.com"
            };
            return obj;
        }
    }
}