using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDay1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ViewDataSample()
        {
            ViewData["data"] = "hello there";
            ViewData.Add("info", "How are you");
            return View();
        }
        public ActionResult DataSharingTech()
        {
            ViewData["Name"] = "Shree";
            List<string> nameList = new List<string>();
            nameList.Add("Michal");
            nameList.Add("Tom");
            nameList.Add("Angelina");
            nameList.Add("Kangana");
            ViewData["List"] = nameList;
            ViewBag.ListInfo = nameList;
            return View();
        }

        //public ActionResult DataSharingTechNew()
        //{
        //    //ViewBag["Name"] = "Shree";
        //    List<string> nameList = new List<string>();
        //    nameList.Add("Michal");
        //    nameList.Add("Tom");
        //    nameList.Add("Angelina");
        //    nameList.Add("Kangana");
        //    ViewData["List"] = nameList;
        //    return View();
        //}
    }
}