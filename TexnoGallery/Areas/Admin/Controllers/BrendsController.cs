using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TexnoGallery.Models;

namespace TexnoGallery.Areas.Admin.Controllers
{
    public class BrendsController : Controller
    {
        private texnoEntities db = new texnoEntities();

        // GET: Admin/Brends
        public ActionResult Index()
        {
            return View(db.Brend.ToList());
        }

        // GET: Admin/Brends/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Brend brend = db.Brend.Find(id);
            if (brend == null)
            {
                return HttpNotFound();
            }
            return View(brend);
        }

        // GET: Admin/Brends/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Brends/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,BrendImg")] Brend brend)
        {
            if (ModelState.IsValid)
            {
                db.Brend.Add(brend);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(brend);
        }

        // GET: Admin/Brends/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Brend brend = db.Brend.Find(id);
            if (brend == null)
            {
                return HttpNotFound();
            }
            return View(brend);
        }

        // POST: Admin/Brends/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,BrendImg")] Brend brend)
        {
            if (ModelState.IsValid)
            {
                db.Entry(brend).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(brend);
        }

        // GET: Admin/Brends/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Brend brend = db.Brend.Find(id);
            if (brend == null)
            {
                return HttpNotFound();
            }
            return View(brend);
        }

        // POST: Admin/Brends/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Brend brend = db.Brend.Find(id);
            db.Brend.Remove(brend);
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
