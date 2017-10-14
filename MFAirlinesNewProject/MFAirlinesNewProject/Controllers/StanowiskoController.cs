using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MFAirlinesNewProject.Models;

namespace MFAirlinesNewProject.Controllers
{
    public class StanowiskoController : Controller
    {
        private AirlinesContext db = new AirlinesContext();

        // GET: Stanowisko
        public ActionResult Index()
        {
            return View(db.Stanowiska.ToList());
        }

        // GET: Stanowisko/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stanowisko stanowisko = db.Stanowiska.Find(id);
            if (stanowisko == null)
            {
                return HttpNotFound();
            }
            return View(stanowisko);
        }

        // GET: Stanowisko/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stanowisko/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StanowiskoId,Name")] Stanowisko stanowisko)
        {
            if (ModelState.IsValid)
            {
                db.Stanowiska.Add(stanowisko);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(stanowisko);
        }

        // GET: Stanowisko/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stanowisko stanowisko = db.Stanowiska.Find(id);
            if (stanowisko == null)
            {
                return HttpNotFound();
            }
            return View(stanowisko);
        }

        // POST: Stanowisko/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StanowiskoId,Name")] Stanowisko stanowisko)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stanowisko).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stanowisko);
        }

        // GET: Stanowisko/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stanowisko stanowisko = db.Stanowiska.Find(id);
            if (stanowisko == null)
            {
                return HttpNotFound();
            }
            return View(stanowisko);
        }

        // POST: Stanowisko/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Stanowisko stanowisko = db.Stanowiska.Find(id);
            db.Stanowiska.Remove(stanowisko);
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
