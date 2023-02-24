using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_example.Controllers
{
    public class MarksDetailsController : Controller
    {
        // GET: MarksDetails
        public ActionResult marksShow()
        {
            return View();
        }
    }
}