using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelPartner.Data.Repository;

namespace TravelPartner.Controllers
{
    public class PackageController : Controller
    {

        // GET: Package
        public ActionResult Index()
        {
            PackageRepository packages = new PackageRepository();
            var list = packages.GetAll();
            return View(list);
        }
    }
}