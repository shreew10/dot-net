using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using intro_mvc_example.Models;

namespace intro_mvc_example.Controllers
{
    public class PersonalController : Controller
    {

        public ActionResult DisplayControls()
        {

            return View();
        }

        [HttpPost]
        public ActionResult SaveData(PersonalDetail p)
        {

            var a = p.PId;
            var b = p.PGender;
            var c = p.PCity;
            var d = p.Status;

            return View();
        }


    }
}