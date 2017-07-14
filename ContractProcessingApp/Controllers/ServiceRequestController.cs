using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ContractProcessingApp.Models;
using Microsoft.AspNet.Identity;

namespace ContractProcessingApp.Controllers
{
    [Authorize(Roles ="Cust, Empl, Admin")]
    public class ServiceRequestController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ServiceRequest
        public ActionResult Index()
        {
            if (User.IsInRole("Cust"))
            {
                ViewBag.Message = "Service Request";
            }
            else if (User.IsInRole("Empl"))
            {
                ViewBag.Message = "Service Processing";
            }
            else
            {
                ViewBag.Message = "Request Administration";
            }
            
            var serviceRequests = db.ServiceRequests.Include(s => s.User);
            return View(serviceRequests.ToList());
        }

        // GET: ServiceRequest/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceRequest serviceRequest = db.ServiceRequests.Find(id);
            if (serviceRequest == null)
            {
                return HttpNotFound();
            }
            return View(serviceRequest);
        }

        // GET: ServiceRequest/Create
        public ActionResult Create()
        {
            ViewBag.CustomerID = new SelectList(db.Users, "Id", "Email");

            var countries = db.Countries.ToList();
            List<SelectListItem> clist = new List<SelectListItem>();
            clist.Add(new SelectListItem { Text = "--Select Country--", Value = "0" });

            foreach (var m in countries)
            {
                clist.Add(new SelectListItem { Text = m.CountryName, Value = m.CountryID.ToString() });
            }
            ViewBag.country = clist;           

            return View();
        }

        // POST: ServiceRequest/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ServiceRequestID,RequestCategory,Summary,RequestCountry,RequestRegion,RequestCity,AdditionalLocationInfo,Email,PhoneNumber,StartDate,CompleteDate,Status")] ServiceRequest serviceRequest)
        {
            if (ModelState.IsValid)
            {
                serviceRequest.CustomerID = User.Identity.GetUserId();
                db.ServiceRequests.Add(serviceRequest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustomerID = new SelectList(db.Users, "Id", "Email", serviceRequest.CustomerID);
            return View(serviceRequest);
        }

        // GET: ServiceRequest/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceRequest serviceRequest = db.ServiceRequests.Find(id);
            if (serviceRequest == null)
            {
                return HttpNotFound();
            }
            ViewBag.CustomerID = new SelectList(db.Users, "Id", "Email", serviceRequest.CustomerID);
            return View(serviceRequest);
        }

        // POST: ServiceRequest/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ServiceRequestID,RequestCategory,Summary,RequestCountry,RequestRegion,RequestCity,AdditionalLocationInfo,Email,PhoneNumber,StartDate,CompleteDate,DataCreated,Status,CustomerID")] ServiceRequest serviceRequest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(serviceRequest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustomerID = new SelectList(db.Users, "Id", "Email", serviceRequest.CustomerID);
            return View(serviceRequest);
        }

        // GET: ServiceRequest/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceRequest serviceRequest = db.ServiceRequests.Find(id);
            if (serviceRequest == null)
            {
                return HttpNotFound();
            }
            return View(serviceRequest);
        }

        // POST: ServiceRequest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ServiceRequest serviceRequest = db.ServiceRequests.Find(id);
            db.ServiceRequests.Remove(serviceRequest);
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
