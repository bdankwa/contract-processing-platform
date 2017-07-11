using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContractProcessingApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult HowItWorks()
        {
            ViewBag.Message = "How it Works.";

            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Message = "Services.";

            return View();
        }

        public ActionResult Portfolio()
        {
            ViewBag.Message = "Portfolio.";

            return View();
        }

        [Authorize]
        public ActionResult Welcome()
        {
            //ViewBag.Message = "Customer";

            return View();
        }
    }
}