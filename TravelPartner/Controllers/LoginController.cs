using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelPartner.Data.Entities;
using TravelPartner.Data.Repository;

namespace TravelPartner.Controllers
{
    public class LoginController : Controller
    {
        private LoginRepository loginRepo = new LoginRepository();
        // GET: Login
        public ActionResult Index()
        {
            return View("LoginCheck", new Login());
        }

        public ActionResult LoginCheck(Login loginModel)
        {
            var found = loginModel.kusername == "Admin" && loginModel.kpassword == "Admin123";

            if (found)
            {
                Session["login"] = "Admin";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Error = "InValid Credentials";
                return View("LoginCheck", new Login());
            }
        }
        public ActionResult RegisterUser(string uname, string password)
        {
            var res = loginRepo.InsertUser(uname, password);
            Session["login"] = res != null ? uname : "";
            return Json(res);
        }
    }
}