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

        public ActionResult RequestNew(Models.RequestCertificateModel model)
        {
            if (model == null)
            {
                model = new Models.RequestCertificateModel();
            }

            model.RequestedBy = User.Identity.Name;

            return View(model);
        }

        // Request (confirm step) a new certificate
        public ActionResult RequestConfirm(Models.RequestCertificateModel model)
        {
            if (model == null)
            {
                model = new Models.RequestCertificateModel();
            }

            model.RequestedBy = User.Identity.Name;
            CA.Common.CA c = new Common.CA();
            string dn = string.Empty;
            int keyLength = 0;
            string hashAlgo = string.Empty;
            c.DecodeCSR(model.CSR, out dn, out keyLength, out hashAlgo);

            model.DistingishedName = dn;
            model.PublicKeyLength = keyLength;
            model.HashAlgorithm = hashAlgo;

            return View(model);
        }

        public ActionResult RequestIssue(Models.RequestCertificateModel model)
        {
            CA.Common.CA c = new Common.CA();

            // Process the request
            try {
                c.Server = Helpers.Configuration.CAServer;
                string cerResult = c.Request(model.CSR);

                // Log certificate
                DAL.Certificate cer = new DAL.Certificate();
                cer.CER = cerResult;
                //cer.LinkedGroupId = model.AssignedGroup;
                cer.RequestedByUser = model.RequestedBy;
                cer.UserFriendlyName = model.FriendlyName;
                cer.RequestedOn = DateTime.UtcNow;
                cer.PublicKeyLength = model.PublicKeyLength;
                cer.HashAlgorithm = model.HashAlgorithm;
                cer.DistingishedName = model.DistingishedName;
                cer = CertificateRepository.Update(cer);

                model.Issued = true;
                model.CertificateId = cer.ID;
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
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