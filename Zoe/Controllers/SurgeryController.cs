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
    public class SurgeryController : Controller
    {
        private ZoeContext db = new ZoeContext();
        private UsersContext usersdb = new UsersContext();

        //
        // GET: /Surgery/

        public ActionResult Index()
        {
            var surgeries = (from surgery in db.Surgeries
                             where surgery.FechaFinalizacion >= DateTime.Today
                             select surgery).OrderBy(model => new { model.Doctor_UsersId, model.FechaInicio }).ToList();
            return View(surgeries);
        }

        //
        // GET: /Surgery/Details/5

        public ActionResult Details()
        {
            var userid = (from user in usersdb.UserProfiles where user.UserName == User.Identity.Name select user).First().UserId;
            var surgeries = (from surgery in db.Surgeries
                             where surgery.FechaFinalizacion >= DateTime.Today && surgery.Doctor_UsersId == userid 
                             select surgery).OrderBy(model => model.FechaInicio).ToList();
            return View(surgeries);
        }

        //
        // GET: /Surgery/Create

        public ActionResult Create()
        {
            ViewData["SurgeryTypes"] = db.SurgeryTypes.ToList();
            ViewData["Patients"] = db.Patients.ToList();

            var DoctorList = new List<UserProfile>();
            foreach (var user in usersdb.UserProfiles)
            {
                if (System.Web.Security.Roles.IsUserInRole(user.UserName, "Doctor"))
                {
                    DoctorList.Add(user);
                }
            }
            ViewData["Doctors"] = DoctorList;
            return View();
        }

        //
        // POST: /Surgery/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Surgery surgery)
        {
            if (ModelState.IsValid)
            {
                var CurrentSurgeryType = (from surgerytype in db.SurgeryTypes select surgerytype).First();
                surgery.FechaFinalizacion = surgery.FechaInicio.AddHours(CurrentSurgeryType.Horas).AddMinutes(CurrentSurgeryType.Minutos);
                var conflictsur = (from sur in db.Surgeries
                                   where ((DateTime.Compare(sur.FechaInicio, surgery.FechaInicio) < 0 && DateTime.Compare(surgery.FechaInicio, sur.FechaFinalizacion) < 0) || (DateTime.Compare(sur.FechaInicio, surgery.FechaFinalizacion) < 0 && DateTime.Compare(surgery.FechaFinalizacion, sur.FechaFinalizacion) < 0)) && sur.Doctor_UsersId == surgery.Doctor_UsersId
                                   select sur).ToList();
                if (conflictsur.Count() > 0)
                {
                    TempData["ResultMessage"] = "Hay cirugías programadas para esa hora";
                    return RedirectToAction("Index", "Surgery");
                }
                db.Surgeries.Add(surgery);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(surgery);
        }

        //
        // GET: /Surgery/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Surgery surgery = db.Surgeries.Find(id);
            if (surgery == null)
            {
                return HttpNotFound();
            }
            return View(surgery);
        }

        //
        // POST: /Surgery/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Surgery surgery)
        {
            if (ModelState.IsValid)
            {
                db.Entry(surgery).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details");
            }
            return View(surgery);
        }

        //
        // GET: /Surgery/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Surgery surgery = db.Surgeries.Find(id);
            if (surgery == null)
            {
                return HttpNotFound();
            }
            return View(surgery);
        }

        //
        // POST: /Surgery/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Surgery surgery = db.Surgeries.Find(id);
            db.Surgeries.Remove(surgery);
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