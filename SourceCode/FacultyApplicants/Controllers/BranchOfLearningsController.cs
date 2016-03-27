using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FacultyApplicants.Models;

namespace FacultyApplicants.Controllers
{
    public class BranchOfLearningsController : Controller
    {
        private ApplicantsContext db = new ApplicantsContext();

        // GET: BranchOfLearnings
        public ActionResult Index()
        {
            return View(db.Reviews.ToList());
        }

        // GET: BranchOfLearnings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BranchOfLearning branchOfLearning = db.Reviews.Find(id);
            if (branchOfLearning == null)
            {
                return HttpNotFound();
            }
            return View(branchOfLearning);
        }

        // GET: BranchOfLearnings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BranchOfLearnings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Faculty")] BranchOfLearning branchOfLearning)
        {
            if (ModelState.IsValid)
            {
                db.Reviews.Add(branchOfLearning);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(branchOfLearning);
        }

        // GET: BranchOfLearnings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BranchOfLearning branchOfLearning = db.Reviews.Find(id);
            if (branchOfLearning == null)
            {
                return HttpNotFound();
            }
            return View(branchOfLearning);
        }

        // POST: BranchOfLearnings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] BranchOfLearning branchOfLearning)
        {
            if (ModelState.IsValid)
            {
                db.Entry(branchOfLearning).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(branchOfLearning);
        }

        // GET: BranchOfLearnings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BranchOfLearning branchOfLearning = db.Reviews.Find(id);
            if (branchOfLearning == null)
            {
                return HttpNotFound();
            }
            return View(branchOfLearning);
        }

        // POST: BranchOfLearnings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BranchOfLearning branchOfLearning = db.Reviews.Find(id);
            db.Reviews.Remove(branchOfLearning);
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
