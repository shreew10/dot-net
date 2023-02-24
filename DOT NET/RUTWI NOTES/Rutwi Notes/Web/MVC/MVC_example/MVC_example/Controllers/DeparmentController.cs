using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_example.Controllers
{
    public class DeparmentController : Controller
    {
        // GET: Deparment
        public ActionResult deptDetails()
        {
            return View();
        }
    }
}