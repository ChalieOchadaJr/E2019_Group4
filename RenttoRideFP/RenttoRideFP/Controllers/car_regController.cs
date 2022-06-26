using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RenttoRideFP.Models;

namespace RenttoRideFP.Controllers
{
    public class car_regController : Controller
    {
        private RenttoRideDBEntities db = new RenttoRideDBEntities();

        // GET: car_reg
        public ActionResult Index()
        {
            return View(db.car_reg.ToList());
        }

        // GET: car_reg/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            car_reg car_reg = db.car_reg.Find(id);
            if (car_reg == null)
            {
                return HttpNotFound();
            }
            return View(car_reg);
        }

        // GET: car_reg/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: car_reg/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "car_id,car_plateno,car_brand,car_model,car_color,car_capacity,car_availability")] car_reg car_reg)
        {
            if (ModelState.IsValid)
            {
                db.car_reg.Add(car_reg);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(car_reg);
        }

        // GET: car_reg/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            car_reg car_reg = db.car_reg.Find(id);
            if (car_reg == null)
            {
                return HttpNotFound();
            }
            return View(car_reg);
        }

        // POST: car_reg/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "car_id,car_plateno,car_brand,car_model,car_color,car_capacity,car_availability")] car_reg car_reg)
        {
            if (ModelState.IsValid)
            {
                db.Entry(car_reg).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(car_reg);
        }

        // GET: car_reg/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            car_reg car_reg = db.car_reg.Find(id);
            if (car_reg == null)
            {
                return HttpNotFound();
            }
            return View(car_reg);
        }

        // POST: car_reg/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            car_reg car_reg = db.car_reg.Find(id);
            db.car_reg.Remove(car_reg);
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
