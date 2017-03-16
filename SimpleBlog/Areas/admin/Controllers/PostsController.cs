using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Areas.admin.Controllers
{
    
    public class PostsController : Controller
    {
        [Authorize(Roles ="admin")]
        // GET: admin/Posts
        public ActionResult Index()
        {
            return Content("Admin PostsController Index");
        }
    }
}