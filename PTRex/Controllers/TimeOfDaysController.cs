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
    public class TimeOfDaysController : Controller
    {
        private PTRexEntities db = new PTRexEntities();

        // GET: TimeOfDays
        public ActionResult Index()
        {
            return View(db.TimeOfDays.ToList());
        }

        // GET: TimeOfDays/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeOfDay timeOfDay = db.TimeOfDays.Find(id);
            if (timeOfDay == null)
            {
                return HttpNotFound();
            }
            return View(timeOfDay);
        }

        // GET: TimeOfDays/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TimeOfDays/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TimeOfDay1")] TimeOfDay timeOfDay)
        {
            if (ModelState.IsValid)
            {
                db.TimeOfDays.Add(timeOfDay);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(timeOfDay);
        }

        // GET: TimeOfDays/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeOfDay timeOfDay = db.TimeOfDays.Find(id);
            if (timeOfDay == null)
            {
                return HttpNotFound();
            }
            return View(timeOfDay);
        }

        // POST: TimeOfDays/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TimeOfDay1")] TimeOfDay timeOfDay)
        {
            if (ModelState.IsValid)
            {
                db.Entry(timeOfDay).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(timeOfDay);
        }

        // GET: TimeOfDays/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeOfDay timeOfDay = db.TimeOfDays.Find(id);
            if (timeOfDay == null)
            {
                return HttpNotFound();
            }
            return View(timeOfDay);
        }

        // POST: TimeOfDays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TimeOfDay timeOfDay = db.TimeOfDays.Find(id);
            db.TimeOfDays.Remove(timeOfDay);
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
