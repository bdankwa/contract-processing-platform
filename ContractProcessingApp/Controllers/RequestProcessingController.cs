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
        // GET: RequestProcessing
        public ActionResult Index()
        {
            return View();
        }

        // GET: Approvals
        public ActionResult Approvals()
        {
            return View();
        }

        // GET: Processing
        public ActionResult Processing()
        {
            return View();
        }
    }
}