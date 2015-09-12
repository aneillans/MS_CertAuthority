using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CA.Portal.Controllers
{
    public class CertificatesController : Controller
    {
        [Dependency]
        public CA.DAL.Repositories.ICertificateRepository CertificateRepository { get; set; }

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
                // Process the request
                CA.Common.CA c = new Common.CA();
                c.Server = Helpers.Configuration.CAServer;
                string cerResult = c.Request(model.CSR);

                // Log certificate
                DAL.Certificate cer = new DAL.Certificate();
                cer.CER = cerResult;
                cer.CertificateName = string.Empty;
                //cer.LinkedGroupId = model.AssignedGroup;
                cer.RequestedByUser = model.RequestedBy;
                cer.UserFriendlyName = model.FriendlyName;
                cer.RequestedOn = DateTime.UtcNow;
                CertificateRepository.Update(cer);
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