﻿
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
    public class AboutSiteController : Controller
    {
        private texnoEntities db = new texnoEntities();

        // GET: Admin/AboutSite
        public ActionResult Index()
        {
            return View(db.AboutUs.ToList());
        }

        // GET: Admin/AboutSite/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutUs aboutUs = db.AboutUs.Find(id);
            if (aboutUs == null)
            {
                return HttpNotFound();
            }
            return View(aboutUs);
        }

        // GET: Admin/AboutSite/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/AboutSite/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Description,AboutImage")] AboutUs aboutUs)
        {
            if (ModelState.IsValid)
            {
                db.AboutUs.Add(aboutUs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aboutUs);
        }

        // GET: Admin/AboutSite/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutUs aboutUs = db.AboutUs.Find(id);
            if (aboutUs == null)
            {
                return HttpNotFound();
            }
            return View(aboutUs);
        }

        // POST: Admin/AboutSite/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Description,AboutImage")] AboutUs aboutUs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aboutUs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aboutUs);
        }

        // GET: Admin/AboutSite/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutUs aboutUs = db.AboutUs.Find(id);
            if (aboutUs == null)
            {
                return HttpNotFound();
            }
            return View(aboutUs);
        }

        // POST: Admin/AboutSite/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AboutUs aboutUs = db.AboutUs.Find(id);
            db.AboutUs.Remove(aboutUs);
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
