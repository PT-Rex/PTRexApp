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
    public class PainLevelsController : Controller
    {
        private PTRexEntities db = new PTRexEntities();

        // GET: PainLevels
        public ActionResult Index()
        {
            return View(db.PainLevels.ToList());
        }

        // GET: PainLevels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PainLevel painLevel = db.PainLevels.Find(id);
            if (painLevel == null)
            {
                return HttpNotFound();
            }
            return View(painLevel);
        }

        // GET: PainLevels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PainLevels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,PainLevel1")] PainLevel painLevel)
        {
            if (ModelState.IsValid)
            {
                db.PainLevels.Add(painLevel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(painLevel);
        }

        // GET: PainLevels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PainLevel painLevel = db.PainLevels.Find(id);
            if (painLevel == null)
            {
                return HttpNotFound();
            }
            return View(painLevel);
        }

        // POST: PainLevels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,PainLevel1")] PainLevel painLevel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(painLevel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(painLevel);
        }

        // GET: PainLevels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PainLevel painLevel = db.PainLevels.Find(id);
            if (painLevel == null)
            {
                return HttpNotFound();
            }
            return View(painLevel);
        }

        // POST: PainLevels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PainLevel painLevel = db.PainLevels.Find(id);
            db.PainLevels.Remove(painLevel);
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
