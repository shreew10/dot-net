using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using intro_mvc_example.Models;

namespace intro_mvc_example.Controllers
{
    public class DeptController : Controller
    {
        // GET: Dept
        public ActionResult DeptData()
        {
            DeptBL deptBLObj = new DeptBL();
            DeptModel d = deptBLObj.deptFun();
            return View(d);
        }

    }
}