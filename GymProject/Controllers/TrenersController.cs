using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GymProject.Models;
using gymApp.Models;

namespace GymProject.Controllers
{
    public class TrenersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Treners
        public ActionResult Index()
        {
            return View(db.Treners.ToList());
        }

        // GET: Treners/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trener trener = db.Treners.Find(id);
            if (trener == null)
            {
                return HttpNotFound();
            }
            return View(trener);
        }

        // GET: Treners/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Treners/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,brojNaKlienti,nameVraboten,emailVraboten,kodVraboten,telefonskiBrojVraboten")] Trener trener)
        {
            if (ModelState.IsValid)
            {
                db.Treners.Add(trener);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trener);
        }

        // GET: Treners/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trener trener = db.Treners.Find(id);
            if (trener == null)
            {
                return HttpNotFound();
            }
            return View(trener);
        }

        // POST: Treners/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,brojNaKlienti,nameVraboten,emailVraboten,kodVraboten,telefonskiBrojVraboten")] Trener trener)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trener).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trener);
        }

        // GET: Treners/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trener trener = db.Treners.Find(id);
            if (trener == null)
            {
                return HttpNotFound();
            }
            return View(trener);
        }

        // POST: Treners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Trener trener = db.Treners.Find(id);
            db.Treners.Remove(trener);
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
