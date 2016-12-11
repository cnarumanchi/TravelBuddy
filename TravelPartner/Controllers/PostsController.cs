using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelPartner.Data.Entities;
using TravelPartner.Data.Repository;
namespace TravelPartner.Controllers
{
    public class PostsController : Controller
    {
        PostsRepository postRepository = new PostsRepository();
        // GET: Posts
        public ActionResult Index()
        {
            var posts = postRepository.GetPosts();
            return View(posts);
        }

        public ActionResult WritePost()
        {
            return View("CreatePost");
        }
        public ActionResult CreatePost(postVM post)
        {
            if(post.Title==null||post.Body==null|| post.FromLocation==null || post.ToLocation==null)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            //Login user = (Login)Session["login"];
            var postModel = new Post();
            //if (user == null)
            //    postModel.User.LoginId = 2;
            //else
            //    postModel.User.LoginId = user.LoginId;
             postModel.Body = post.Body;
            postModel.FromDate = post.FromDate;
            postModel.ToDate = post.ToDate;
            postModel.FromLocation = post.FromLocation;
            postModel.ToLocation = post.ToLocation;
            postModel.Title = post.Title;
            postModel.Timestamp = DateTime.Now;
            //postModel.User.LoginId = 
            var result = postRepository.InsertPost(postModel);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
