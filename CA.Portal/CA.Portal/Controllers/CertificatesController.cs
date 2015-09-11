using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CA.Portal.Controllers
{
    public class CertificatesController : Controller
    {
        // Browse certificates
        public ActionResult Index()
        {
            return View();
        }

        // Request a new certificate
        public ActionResult RequestNew()
        {
            return View();
        }

        // Monitor certificate expiry
        public ActionResult Monitor()
        {
            return View();
        }
    }
}