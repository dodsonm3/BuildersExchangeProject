using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BuildersExchangeProject.Models;

namespace BuildersExchangeProject.Controllers
{
    public class LINKsController : Controller
    {
        private SANDEntities db = new SANDEntities();

        // GET: LINKs
        public ActionResult Index()
        {
            var lINKs = db.LINKs.Include(l => l.FILTER);
            return View(lINKs.ToList());
        }

        // GET: LINKs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LINK lINK = db.LINKs.Find(id);
            if (lINK == null)
            {
                return HttpNotFound();
            }
            return View(lINK);
        }

        // GET: LINKs/Create
        public ActionResult Create()
        {
            ViewBag.FILTER_ID = new SelectList(db.FILTERs, "FILTER_ID", "FILTER_NAME");
            return View();
        }

        // POST: LINKs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "URL_ID,URL,FILTER_ID")] LINK lINK)
        {
            if (ModelState.IsValid)
            {
                db.LINKs.Add(lINK);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FILTER_ID = new SelectList(db.FILTERs, "FILTER_ID", "FILTER_NAME", lINK.FILTER_ID);
            return View(lINK);
        }

        // GET: LINKs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LINK lINK = db.LINKs.Find(id);
            if (lINK == null)
            {
                return HttpNotFound();
            }
            ViewBag.FILTER_ID = new SelectList(db.FILTERs, "FILTER_ID", "FILTER_NAME", lINK.FILTER_ID);
            return View(lINK);
        }

        // POST: LINKs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "URL_ID,URL,FILTER_ID")] LINK lINK)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lINK).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FILTER_ID = new SelectList(db.FILTERs, "FILTER_ID", "FILTER_NAME", lINK.FILTER_ID);
            return View(lINK);
        }

        // GET: LINKs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LINK lINK = db.LINKs.Find(id);
            if (lINK == null)
            {
                return HttpNotFound();
            }
            return View(lINK);
        }

        // POST: LINKs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LINK lINK = db.LINKs.Find(id);
            db.LINKs.Remove(lINK);
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
