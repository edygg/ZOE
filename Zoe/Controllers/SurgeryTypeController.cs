using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zoe.Models;

namespace Zoe.Controllers
{
    public class SurgeryTypeController : Controller
    {
        private ZoeContext db = new ZoeContext();

        //
        // GET: /SurgeryType/

        public ActionResult Index()
        {
            return View(db.SurgeryTypes.ToList());
        }

        //
        // GET: /SurgeryType/Details/5

        public ActionResult Details(int id = 0)
        {
            SurgeryType surgerytype = db.SurgeryTypes.Find(id);
            if (surgerytype == null)
            {
                return HttpNotFound();
            }
            return View(surgerytype);
        }

        //
        // GET: /SurgeryType/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /SurgeryType/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SurgeryType surgerytype)
        {
            if (ModelState.IsValid)
            {
                db.SurgeryTypes.Add(surgerytype);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(surgerytype);
        }

        //
        // GET: /SurgeryType/Edit/5

        public ActionResult Edit(int id = 0)
        {
            SurgeryType surgerytype = db.SurgeryTypes.Find(id);
            if (surgerytype == null)
            {
                return HttpNotFound();
            }
            return View(surgerytype);
        }

        //
        // POST: /SurgeryType/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SurgeryType surgerytype)
        {
            if (ModelState.IsValid)
            {
                db.Entry(surgerytype).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(surgerytype);
        }

        //
        // GET: /SurgeryType/Delete/5

        public ActionResult Delete(int id = 0)
        {
            SurgeryType surgerytype = db.SurgeryTypes.Find(id);
            if (surgerytype == null)
            {
                return HttpNotFound();
            }
            return View(surgerytype);
        }

        //
        // POST: /SurgeryType/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SurgeryType surgerytype = db.SurgeryTypes.Find(id);
            db.SurgeryTypes.Remove(surgerytype);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}