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
    public class StudentPerCoursesController : Controller
    {
        private PrivateSchoolContext db = new PrivateSchoolContext();

        // GET: StudentPerCourses
        public ActionResult Index()
        {
            var studentPerCourses = db.StudentPerCourses.Include(s => s.Course).Include(s => s.Student);
            return View(studentPerCourses.ToList());
        }

        // GET: StudentPerCourses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentPerCourse studentPerCourse = db.StudentPerCourses.Find(id);
            if (studentPerCourse == null)
            {
                return HttpNotFound();
            }
            return View(studentPerCourse);
        }

        // GET: StudentPerCourses/Create
        public ActionResult Create()
        {
            ViewBag.CourseID = new SelectList(db.Courses, "ID", "Title");
            ViewBag.StudentID = new SelectList(db.Students, "ID", "FirstName");
            return View();
        }

        // POST: StudentPerCourses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,StudentID,CourseID")] StudentPerCourse studentPerCourse)
        {
            if (ModelState.IsValid)
            {
                db.StudentPerCourses.Add(studentPerCourse);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseID = new SelectList(db.Courses, "ID", "Title", studentPerCourse.CourseID);
            ViewBag.StudentID = new SelectList(db.Students, "ID", "FirstName", studentPerCourse.StudentID);
            return View(studentPerCourse);
        }

        // GET: StudentPerCourses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentPerCourse studentPerCourse = db.StudentPerCourses.Find(id);
            if (studentPerCourse == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseID = new SelectList(db.Courses, "ID", "Title", studentPerCourse.CourseID);
            ViewBag.StudentID = new SelectList(db.Students, "ID", "FirstName", studentPerCourse.StudentID);
            return View(studentPerCourse);
        }

        // POST: StudentPerCourses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,StudentID,CourseID")] StudentPerCourse studentPerCourse)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentPerCourse).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseID = new SelectList(db.Courses, "ID", "Title", studentPerCourse.CourseID);
            ViewBag.StudentID = new SelectList(db.Students, "ID", "FirstName", studentPerCourse.StudentID);
            return View(studentPerCourse);
        }

        // GET: StudentPerCourses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentPerCourse studentPerCourse = db.StudentPerCourses.Find(id);
            if (studentPerCourse == null)
            {
                return HttpNotFound();
            }
            return View(studentPerCourse);
        }

        // POST: StudentPerCourses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentPerCourse studentPerCourse = db.StudentPerCourses.Find(id);
            db.StudentPerCourses.Remove(studentPerCourse);
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
