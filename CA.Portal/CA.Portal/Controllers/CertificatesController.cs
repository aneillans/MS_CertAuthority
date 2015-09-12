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
        public ActionResult RequestNew(Models.RequestCertificateModel model)
        {
            if (model == null)
            {
                model = new Models.RequestCertificateModel();
            }

            model.RequestedBy = User.Identity.Name;

            if (ModelState.IsValid)
            {

            }
            else
            {
                // Let it return to the request screen
            }

            return View(model);
        }

        // Monitor certificate expiry
        public ActionResult Monitor()
        {
            return View();
        }
    }
}