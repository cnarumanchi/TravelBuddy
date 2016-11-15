using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelPartner.Data.Entities;
namespace TravelPartner.Controllers
{
    public class PostsController : Controller
    {
        // GET: Posts
        public ActionResult Index()
        { 
            return View(new Post());
        }
    }
}