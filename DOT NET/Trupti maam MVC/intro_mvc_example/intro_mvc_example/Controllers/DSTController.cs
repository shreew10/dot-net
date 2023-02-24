using intro_mvc_example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace intro_mvc_example.Controllers
{
    public class DSTController : Controller
    {
        // GET: DST
        public ActionResult DataSharingtech()
        {
            ViewData["VD_Name"] = "Trupti";

            List<string> nameLst = new List<string>();
            nameLst.Add("Rutwi");
            nameLst.Add("Shree");
            nameLst.Add("Nitin");
            nameLst.Add("Kirti");
            ViewData["VD_List"] = nameLst;

            ViewBag.VB_Simple = "Tej";
            ViewBag.VB_List = nameLst;

            TempData["TD"] = "Single TD";
            return View();
        }

        public ActionResult CurrentTD()
        {                                                                                                                                                        
            //var p = TempData["TD"].ToString();
            return View();
        }

        public ActionResult GetDt()
        {
            DeptBL obj = new DeptBL();
            DeptModel d = obj.deptFun();
            return View(d);
        }

    }
}