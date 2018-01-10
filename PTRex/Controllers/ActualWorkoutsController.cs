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
    [Authorize]
    public class ActualWorkoutsController : Controller
    {
        private PTRexEntities db = new PTRexEntities();

        // GET: ActualWorkouts
        public ActionResult Index()
        {
            var actualWorkouts = db.ActualWorkouts.Include(a => a.PainLevel).Include(a => a.TargetWorkout).Include(a => a.TimeOfDay);
            return View(actualWorkouts.ToList());
        }

        // GET: ActualWorkouts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActualWorkout actualWorkout = db.ActualWorkouts.Find(id);
            if (actualWorkout == null)
            {
                return HttpNotFound();
            }
            return View(actualWorkout);
        }

        // GET: ActualWorkouts/Create
        public ActionResult Create()
        {
            ViewBag.PainLevelID = new SelectList(db.PainLevels, "ID", "PainLevel1");
            ViewBag.TargetWorkoutID = new SelectList(db.TargetWorkouts, "ID", "TargetNotes");
            ViewBag.TimeOfDayID = new SelectList(db.TimeOfDays, "ID", "TimeOfDay1");
            return View();
        }

        // POST: ActualWorkouts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TargetWorkoutID,ActualNumSets,ActualNumReps,Date,TimeOfDayID,WeightUsed,PainLevelID,ActualNotes")] ActualWorkout actualWorkout)
        {
            if (ModelState.IsValid)
            {
                db.ActualWorkouts.Add(actualWorkout);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PainLevelID = new SelectList(db.PainLevels, "ID", "PainLevel1", actualWorkout.PainLevelID);
            ViewBag.TargetWorkoutID = new SelectList(db.TargetWorkouts, "ID", "TargetNotes", actualWorkout.TargetWorkoutID);
            ViewBag.TimeOfDayID = new SelectList(db.TimeOfDays, "ID", "TimeOfDay1", actualWorkout.TimeOfDayID);
            return View(actualWorkout);
        }

        // GET: ActualWorkouts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActualWorkout actualWorkout = db.ActualWorkouts.Find(id);
            if (actualWorkout == null)
            {
                return HttpNotFound();
            }
            ViewBag.PainLevelID = new SelectList(db.PainLevels, "ID", "PainLevel1", actualWorkout.PainLevelID);
            ViewBag.TargetWorkoutID = new SelectList(db.TargetWorkouts, "ID", "TargetNotes", actualWorkout.TargetWorkoutID);
            ViewBag.TimeOfDayID = new SelectList(db.TimeOfDays, "ID", "TimeOfDay1", actualWorkout.TimeOfDayID);
            return View(actualWorkout);
        }

        // POST: ActualWorkouts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TargetWorkoutID,ActualNumSets,ActualNumReps,Date,TimeOfDayID,WeightUsed,PainLevelID,ActualNotes")] ActualWorkout actualWorkout)
        {
            if (ModelState.IsValid)
            {
                db.Entry(actualWorkout).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PainLevelID = new SelectList(db.PainLevels, "ID", "PainLevel1", actualWorkout.PainLevelID);
            ViewBag.TargetWorkoutID = new SelectList(db.TargetWorkouts, "ID", "TargetNotes", actualWorkout.TargetWorkoutID);
            ViewBag.TimeOfDayID = new SelectList(db.TimeOfDays, "ID", "TimeOfDay1", actualWorkout.TimeOfDayID);
            return View(actualWorkout);
        }

        // GET: ActualWorkouts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActualWorkout actualWorkout = db.ActualWorkouts.Find(id);
            if (actualWorkout == null)
            {
                return HttpNotFound();
            }
            return View(actualWorkout);
        }

        // POST: ActualWorkouts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ActualWorkout actualWorkout = db.ActualWorkouts.Find(id);
            db.ActualWorkouts.Remove(actualWorkout);
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
