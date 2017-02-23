using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Areas.admin.Controllers
{
    public class UsersController : Controller
    {
        // GET: admin/Users
        public ActionResult Index()
        {
            return Content("Users Index");
        }

        public ActionResult List()
        {
            return Content("Users List");
        }


        public ActionResult Edit(int id=0)
        {
            return Content("Users Edit :"+ id.ToString() );
        }
    }
}