using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RentoRide.Models;

namespace RentoRide.Controllers
{
    public class NewAccountController : Controller
    {
        private RenttoRideDBEntities db = new RenttoRideDBEntities();

        // GET: NewAccount
        public ActionResult Index()
        {
            return View(db.customer_acc.ToList());
        }

        // GET: NewAccount/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            customer_acc customer_acc = db.customer_acc.Find(id);
            if (customer_acc == null)
            {
                return HttpNotFound();
            }
            return View(customer_acc);
        }

        // GET: NewAccount/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewAccount/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,customer_firstname,customer_middlename,customer_lastname,customer_namesuffix,customer_contact,customer_email,customer_password,date_created,date_modified")] customer_acc customer_acc)
        {
            if (ModelState.IsValid)
            {
                db.customer_acc.Add(customer_acc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer_acc);
        }

        // GET: NewAccount/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            customer_acc customer_acc = db.customer_acc.Find(id);
            if (customer_acc == null)
            {
                return HttpNotFound();
            }
            return View(customer_acc);
        }

        // POST: NewAccount/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,customer_firstname,customer_middlename,customer_lastname,customer_namesuffix,customer_contact,customer_email,customer_password,date_created,date_modified")] customer_acc customer_acc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer_acc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer_acc);
        }

        // GET: NewAccount/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            customer_acc customer_acc = db.customer_acc.Find(id);
            if (customer_acc == null)
            {
                return HttpNotFound();
            }
            return View(customer_acc);
        }

        // POST: NewAccount/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            customer_acc customer_acc = db.customer_acc.Find(id);
            db.customer_acc.Remove(customer_acc);
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
