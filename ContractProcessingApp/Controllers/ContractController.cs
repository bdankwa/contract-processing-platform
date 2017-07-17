using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ContractProcessingApp.Models;

namespace ContractProcessingApp.Controllers
{
    [Authorize(Roles ="Empl, Admin")]
    public class ContractController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Contract
        public ActionResult Index()
        {
            var contracts = db.Contracts.Include(c => c.ServiceRequest).Include(c => c.User);
            return View(contracts.ToList());
        }

        // GET: Contract/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contract contract = db.Contracts.Find(id);
            if (contract == null)
            {
                return HttpNotFound();
            }
            return View(contract);
        }

        // GET: Contract/Create
        public ActionResult Create()
        {
            ViewBag.ServiceRequestID = new SelectList(db.ServiceRequests, "ServiceRequestID", "RequestCategory");
            ViewBag.EmployeeID = new SelectList(db.Users, "Id", "Email");
            return View();
        }

        // POST: Contract/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ContractID,ServiceRequestID,EmployeeID")] Contract contract)
        {
            if (ModelState.IsValid)
            {
                db.Contracts.Add(contract);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ServiceRequestID = new SelectList(db.ServiceRequests, "ServiceRequestID", "RequestCategory", contract.ServiceRequestID);
            ViewBag.EmployeeID = new SelectList(db.Users, "Id", "Email", contract.EmployeeID);
            return View(contract);
        }

        // GET: Contract/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contract contract = db.Contracts.Find(id);
            if (contract == null)
            {
                return HttpNotFound();
            }
            ViewBag.ServiceRequestID = new SelectList(db.ServiceRequests, "ServiceRequestID", "RequestCategory", contract.ServiceRequestID);
            ViewBag.EmployeeID = new SelectList(db.Users, "Id", "Email", contract.EmployeeID);
            return View(contract);
        }

        // POST: Contract/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ContractID,ServiceRequestID,EmployeeID")] Contract contract)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contract).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ServiceRequestID = new SelectList(db.ServiceRequests, "ServiceRequestID", "RequestCategory", contract.ServiceRequestID);
            ViewBag.EmployeeID = new SelectList(db.Users, "Id", "Email", contract.EmployeeID);
            return View(contract);
        }

        // GET: Contract/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contract contract = db.Contracts.Find(id);
            if (contract == null)
            {
                return HttpNotFound();
            }
            return View(contract);
        }

        // POST: Contract/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contract contract = db.Contracts.Find(id);
            db.Contracts.Remove(contract);
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
