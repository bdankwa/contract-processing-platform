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
    [Authorize(Roles ="Empl, Admin")]
    public class RequestProcessingController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: RequestProcessing
        public ActionResult Index()
        {
            return View();
        }

        // GET: Approvals
        public ActionResult Approvals()
        {
            var submittedRequests = db.ServiceRequests.Where(x => x.Status == ServiceRequestStatus.Submitted);
            return View(submittedRequests.ToList());
        }

        // GET: Processing
        public ActionResult Processing()
        {
            return View();
        }
    }
}