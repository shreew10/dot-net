using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_example.Controllers
{
    public class DSTController : Controller
    {
        // GET: DST
        public ActionResult dstShow()
        {
            //For ViewData
            ViewData["Name:"] = "Rutwi";
            ViewData.Add("City:", "Sangli");

            List<string> subList = new List<string>();
            subList.Add("C");
            subList.Add("C++");
            subList.Add("SQl");
            subList.Add("Dot Net");

            ViewData["Subjects"] = subList;

            //For ViewBag
            ViewBag.Name = "Prachi";
            ViewBag.City = "Sangli";

            ViewBag.Subjects = subList;

            return View();
        }
    }
}