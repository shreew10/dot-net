using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NTTFramework;

namespace NTTFramework.Controllers
{
    public class tbl_student_detailsController : Controller
    {
        private tempdb_TruptiEntities1 db = new tempdb_TruptiEntities1();

        // GET: tbl_student_details
        public ActionResult Index()
        {
            return View(db.tbl_student_details.ToList());
        }

        // GET: tbl_student_details/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_student_details tbl_student_details = db.tbl_student_details.Find(id);
            if (tbl_student_details == null)
            {
                return HttpNotFound();
            }
            return View(tbl_student_details);
        }

        // GET: tbl_student_details/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_student_details/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "studRollno,studName,studGender,studSubject")] tbl_student_details tbl_student_details)
        {
            if (ModelState.IsValid)
            {
                db.tbl_student_details.Add(tbl_student_details);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_student_details);
        }

        // GET: tbl_student_details/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_student_details tbl_student_details = db.tbl_student_details.Find(id);
            if (tbl_student_details == null)
            {
                return HttpNotFound();
            }
            return View(tbl_student_details);
        }

        // POST: tbl_student_details/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "studRollno,studName,studGender,studSubject")] tbl_student_details tbl_student_details)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_student_details).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_student_details);
        }

        // GET: tbl_student_details/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_student_details tbl_student_details = db.tbl_student_details.Find(id);
            if (tbl_student_details == null)
            {
                return HttpNotFound();
            }
            return View(tbl_student_details);
        }

        // POST: tbl_student_details/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_student_details tbl_student_details = db.tbl_student_details.Find(id);
            db.tbl_student_details.Remove(tbl_student_details);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
