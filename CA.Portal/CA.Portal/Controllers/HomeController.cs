using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CA.Portal.Controllers
{
    public class HomeController : Controller
    {
        [Dependency]
        public CA.DAL.Repositories.IUserRepository UserRepository { get; set; }

        public ActionResult Index()
        {
            Models.BaseUserModel model = new Models.BaseUserModel();

            DAL.User user = UserRepository.GetUser(User.Identity.Name);
            if (user == null)
            {
                return RedirectToAction("NewUser");
            }

            return View(model);
        }

        public ActionResult NewUser()
        {
            ViewBag.Message = "I've not seen you before; please select your default Active Directory Group below, and click Save.";

            return View(new CA.DAL.User());
        }
    }
}