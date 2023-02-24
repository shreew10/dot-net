using intro_mvc_example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//using intro_mvc_example.Models;

namespace intro_mvc_example.Controllers
{
    public class HomeController : Controller
    {

        public string fun()
        {
            return "heloo";
        }

        public int gun1()
        {
            return 1;
        }

        public ActionResult Index()
        {
            TempData["name"] = "Trupti";
            List<string> Student = new List<string>();
            Student.Add("Jignesh");
            Student.Add("Tejas");
            Student.Add("Rakesh");
            ViewData["VDStudent"] = Student;

            ViewData["VDHeader"] = "View Data Example";
            return View();
        }

        public ActionResult About()
        {
            List<string> Student = new List<string>();
            Student.Add("Jignesh");
            Student.Add("Tejas");
            Student.Add("Rakesh");

            ViewBag.VBStudent = Student;
            ViewBag.VBHeader = "View Bag Example";
            return View();
        }

        public ActionResult Contact()
        {
            TempData["TDHeader"] = "TempData Example";
            List<string> Student = new List<string>();
            Student.Add("Jignesh");
            Student.Add("Tejas");
            Student.Add("Rakesh");

            TempData["TDStudent"] = Student;
            return View();
        }

        public ActionResult Show()
        {
            //this function is used for display redirection data of using data: sharing techniques(view data, viewbag, tempdata);
            string a = TempData["name"].ToString();

            //ViewBag.VBData = a;
            ViewBag.VBData = TempData["name"].ToString(); ;
            TempData["TDData"] = TempData["name"].ToString();

            return View();
        }

        [ActionName("EmployeeDetails")]
        public ActionResult EmployeeRegistration()
        {
            return View();
        }


        public ActionResult DisplayData()
        {
            ViewBag.vbHeaderData = "Student List";
            ViewData["vdHeaderData"] = "Employee List";
            TempData["tdHeaderData"] = "Department List";
            TempData["Yes"] = "Department";
            TempData["Trupti"] = "Hey trupti....";

            return View();
        }


        public ActionResult FecthData()
        {
            //ViewBag.VBFetch = ViewBag.vbHeaderData;
            //ViewData["VDFetch"] = ViewData["vdHeaderData"];
            TempData["TDFetch"] = TempData["Trupti"];
            var a = TempData["tdHeaderData"];
            TempData["TDFetch1"] = a;
            return View();
        }





        public ActionResult GetEmpDetails()
        {
            EmpBL obj = new EmpBL();
            Emp e = obj.funEmp();
            return View(e);
        }


        public ActionResult razorExample()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DisplayForm(Emp formModel)
        {
            //do stuff with the formModel
            formModel.ID = formModel.ID;
            return View();
        }
    }
}