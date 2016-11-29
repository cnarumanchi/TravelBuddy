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
            HotelRepository hotel = new HotelRepository();
            var list = hotel.showPackages();
            return View(list);
        }
    }
}