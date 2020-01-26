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
    public class AssignmentPerStudentsController : Controller
    {
        private PrivateSchoolContext db = new PrivateSchoolContext();

        // GET: AssignmentPerStudents
        public ActionResult Index()
        {
            var assignmentPerStudents = db.AssignmentPerStudents.Include(a => a.Assignment).Include(a => a.Student);
            return View(assignmentPerStudents.ToList());
        }

        // GET: AssignmentPerStudents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssignmentPerStudent assignmentPerStudent = db.AssignmentPerStudents.Find(id);
            if (assignmentPerStudent == null)
            {
                return HttpNotFound();
            }
            return View(assignmentPerStudent);
        }

        // GET: AssignmentPerStudents/Create
        public ActionResult Create()
        {
            ViewBag.AssignmentID = new SelectList(db.Assignments, "ID", "Title");
            ViewBag.StudentID = new SelectList(db.Students, "ID", "FirstName");
            return View();
        }

        // POST: AssignmentPerStudents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,StudentID,AssignmentID,OralMark,TotalMark")] AssignmentPerStudent assignmentPerStudent)
        {
            if (ModelState.IsValid)
            {
                db.AssignmentPerStudents.Add(assignmentPerStudent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AssignmentID = new SelectList(db.Assignments, "ID", "Title", assignmentPerStudent.AssignmentID);
            ViewBag.StudentID = new SelectList(db.Students, "ID", "FirstName", assignmentPerStudent.StudentID);
            return View(assignmentPerStudent);
        }

        // GET: AssignmentPerStudents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssignmentPerStudent assignmentPerStudent = db.AssignmentPerStudents.Find(id);
            if (assignmentPerStudent == null)
            {
                return HttpNotFound();
            }
            ViewBag.AssignmentID = new SelectList(db.Assignments, "ID", "Title", assignmentPerStudent.AssignmentID);
            ViewBag.StudentID = new SelectList(db.Students, "ID", "FirstName", assignmentPerStudent.StudentID);
            return View(assignmentPerStudent);
        }

        // POST: AssignmentPerStudents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,StudentID,AssignmentID,OralMark,TotalMark")] AssignmentPerStudent assignmentPerStudent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assignmentPerStudent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AssignmentID = new SelectList(db.Assignments, "ID", "Title", assignmentPerStudent.AssignmentID);
            ViewBag.StudentID = new SelectList(db.Students, "ID", "FirstName", assignmentPerStudent.StudentID);
            return View(assignmentPerStudent);
        }

        // GET: AssignmentPerStudents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssignmentPerStudent assignmentPerStudent = db.AssignmentPerStudents.Find(id);
            if (assignmentPerStudent == null)
            {
                return HttpNotFound();
            }
            return View(assignmentPerStudent);
        }

        // POST: AssignmentPerStudents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AssignmentPerStudent assignmentPerStudent = db.AssignmentPerStudents.Find(id);
            db.AssignmentPerStudents.Remove(assignmentPerStudent);
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
