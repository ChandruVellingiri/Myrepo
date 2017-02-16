using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASP.NETMVCWebApp.Models;

namespace ASP.NETMVCWebApp.Controllers
{
    public class PersonDetailsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PersonDetails
        public ActionResult Index()
        {
            return View(db.PersonDetails.ToList());
        }

        // GET: PersonDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonDetails personDetails = db.PersonDetails.Find(id);
            if (personDetails == null)
            {
                return HttpNotFound();
            }
            return View(personDetails);
        }

        // GET: PersonDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] PersonDetails personDetails)
        {
            if (ModelState.IsValid)
            {
                db.PersonDetails.Add(personDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personDetails);
        }

        // GET: PersonDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonDetails personDetails = db.PersonDetails.Find(id);
            if (personDetails == null)
            {
                return HttpNotFound();
            }
            return View(personDetails);
        }

        // POST: PersonDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] PersonDetails personDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personDetails);
        }

        // GET: PersonDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonDetails personDetails = db.PersonDetails.Find(id);
            if (personDetails == null)
            {
                return HttpNotFound();
            }
            return View(personDetails);
        }

        // POST: PersonDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PersonDetails personDetails = db.PersonDetails.Find(id);
            db.PersonDetails.Remove(personDetails);
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
