using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIexample.Controllers
{
    public class EmpController : ApiController
    {
        [HttpGet]
        public string func()
        {
            //can write code
            return "shree";
        }


        [HttpPost]
        public void func1(dynamic para)
        {
            int id = Convert.ToInt32(para[0].ID.Value);
            string name = Convert.ToString(para[0].Name.Value);

            //ado
            //select

            //can write code


        }
    }
}
