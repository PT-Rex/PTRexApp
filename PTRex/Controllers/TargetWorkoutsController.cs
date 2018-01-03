using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PTRex.Models;

namespace PTRex.Controllers
{
    public class TargetWorkoutsController : Controller
    {
        private PTRexEntities db = new PTRexEntities();

        // GET: TargetWorkouts
        public ActionResult Index()
        {
            var targetWorkouts = db.TargetWorkouts.Include(t => t.Exercis).Include(t => t.UserProfile);
            return View(targetWorkouts.ToList());
        }

        // GET: TargetWorkouts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TargetWorkout targetWorkout = db.TargetWorkouts.Find(id);
            if (targetWorkout == null)
            {
                return HttpNotFound();
            }
            return View(targetWorkout);
        }

        // GET: TargetWorkouts/Create
        public ActionResult Create()
        {
            ViewBag.ExerciseID = new SelectList(db.Exercises, "ID", "Name");
            ViewBag.UserProfileID = new SelectList(db.UserProfiles, "ID", "UserName");
            return View();
        }

        // POST: TargetWorkouts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ExerciseID,ExerciseNickName,TargetNumSets,TargetNumReps,TargetSessionsPerDay,TargetNotes")] TargetWorkout targetWorkout)
        {
            if (ModelState.IsValid)
            {
                db.TargetWorkouts.Add(targetWorkout);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ExerciseID = new SelectList(db.Exercises, "ID", "Name", targetWorkout.ExerciseID);
            ViewBag.UserProfileID = new SelectList(db.UserProfiles, "ID", "UserName", targetWorkout.UserProfileID);
            return View(targetWorkout);
        }

        // GET: TargetWorkouts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TargetWorkout targetWorkout = db.TargetWorkouts.Find(id);
            if (targetWorkout == null)
            {
                return HttpNotFound();
            }
            ViewBag.ExerciseID = new SelectList(db.Exercises, "ID", "Name", targetWorkout.ExerciseID);
            ViewBag.UserProfileID = new SelectList(db.UserProfiles, "ID", "UserName", targetWorkout.UserProfileID);
            return View(targetWorkout);
        }

        // POST: TargetWorkouts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ExerciseID,UserProfileID,TargetNumSets,TargetNumReps,TargetSessionsPerDay,TargetNotes")] TargetWorkout targetWorkout)
        {
            if (ModelState.IsValid)
            {
                db.Entry(targetWorkout).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ExerciseID = new SelectList(db.Exercises, "ID", "Name", targetWorkout.ExerciseID);
            ViewBag.UserProfileID = new SelectList(db.UserProfiles, "ID", "UserName", targetWorkout.UserProfileID);
            return View(targetWorkout);
        }

        // GET: TargetWorkouts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TargetWorkout targetWorkout = db.TargetWorkouts.Find(id);
            if (targetWorkout == null)
            {
                return HttpNotFound();
            }
            return View(targetWorkout);
        }

        // POST: TargetWorkouts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TargetWorkout targetWorkout = db.TargetWorkouts.Find(id);
            db.TargetWorkouts.Remove(targetWorkout);
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
