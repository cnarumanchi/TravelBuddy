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
        private List<User> users = new List<User>();

        // GET: Login
        public ActionResult Index()
        {
            return View("LoginCheck", new Login());
        }

        public ActionResult LoginCheck(string uname, string password)
        {
            var users = loginRepo.GetAllUsers();
            var found = users.Any(x => x.UserName == uname && x.kpassword == password);

            if (found)
            {
                Session["login"] = uname;
                return Json(new { Result = "Success" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                ViewBag.Error = "InValid Credentials";
                return Json(new { Error = "InValid Credentials" }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult RegisterUser(string uname, string password)
        {
            var users = loginRepo.GetAllUsers();
            var exists = users.Any(x => x.UserName == uname);
            if (!exists)
            {
                var res = loginRepo.InsertUser(uname, password);
                Session["login"] = res != 0 ? uname : "";
                return Json(new {Result= res }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Error = "Username already taken" }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}