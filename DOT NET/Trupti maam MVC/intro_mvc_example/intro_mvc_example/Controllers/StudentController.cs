using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using intro_mvc_example.Models;

namespace intro_mvc_example.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult StudentData()
        {
            StudentModel stdObj = new StudentModel();
            stdObj.ID = 1;
            stdObj.Name = "Devaki";
            stdObj.Email = "Devaki@gmail.com";
            stdObj.Address = "Pune";
            return View(stdObj);
        }
    }
}