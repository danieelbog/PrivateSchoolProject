using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PrivateSchool.Data;
using PrivateSchool.Models;

namespace PrivateSchool.Controllers
{
    public class TrainerPerCoursesController : Controller
    {
        private PrivateSchoolContext db = new PrivateSchoolContext();

        // GET: TrainerPerCourses
        public ActionResult Index()
        {
            var trainerPerCourses = db.TrainerPerCourses.Include(t => t.Course).Include(t => t.Trainer);
            return View(trainerPerCourses.ToList());
        }

        // GET: TrainerPerCourses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrainerPerCourse trainerPerCourse = db.TrainerPerCourses.Find(id);
            if (trainerPerCourse == null)
            {
                return HttpNotFound();
            }
            return View(trainerPerCourse);
        }

        // GET: TrainerPerCourses/Create
        public ActionResult Create()
        {
            ViewBag.CourseID = new SelectList(db.Courses, "ID", "Title");
            ViewBag.TrainerID = new SelectList(db.Trainers, "ID", "FirstName");
            return View();
        }

        // POST: TrainerPerCourses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TrainerID,CourseID")] TrainerPerCourse trainerPerCourse)
        {
            if (ModelState.IsValid)
            {
                db.TrainerPerCourses.Add(trainerPerCourse);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseID = new SelectList(db.Courses, "ID", "Title", trainerPerCourse.CourseID);
            ViewBag.TrainerID = new SelectList(db.Trainers, "ID", "FirstName", trainerPerCourse.TrainerID);
            return View(trainerPerCourse);
        }

        // GET: TrainerPerCourses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrainerPerCourse trainerPerCourse = db.TrainerPerCourses.Find(id);
            if (trainerPerCourse == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseID = new SelectList(db.Courses, "ID", "Title", trainerPerCourse.CourseID);
            ViewBag.TrainerID = new SelectList(db.Trainers, "ID", "FirstName", trainerPerCourse.TrainerID);
            return View(trainerPerCourse);
        }

        // POST: TrainerPerCourses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TrainerID,CourseID")] TrainerPerCourse trainerPerCourse)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trainerPerCourse).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseID = new SelectList(db.Courses, "ID", "Title", trainerPerCourse.CourseID);
            ViewBag.TrainerID = new SelectList(db.Trainers, "ID", "FirstName", trainerPerCourse.TrainerID);
            return View(trainerPerCourse);
        }

        // GET: TrainerPerCourses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrainerPerCourse trainerPerCourse = db.TrainerPerCourses.Find(id);
            if (trainerPerCourse == null)
            {
                return HttpNotFound();
            }
            return View(trainerPerCourse);
        }

        // POST: TrainerPerCourses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TrainerPerCourse trainerPerCourse = db.TrainerPerCourses.Find(id);
            db.TrainerPerCourses.Remove(trainerPerCourse);
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
