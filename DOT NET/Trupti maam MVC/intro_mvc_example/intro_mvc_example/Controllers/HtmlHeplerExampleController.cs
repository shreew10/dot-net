using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace intro_mvc_example.Controllers
{
    public class HtmlHeplerExampleController : Controller
    {
        //HtmlHeplerExample
        public ActionResult Display()
        {
            return View();
        }


        //action name example
        [ActionName("xyz")]
        public ActionResult GetEmployeeData()
        {
            return View();
        }

    }
}