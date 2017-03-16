using SimpleBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            return View(new AuthLogin());
        }

        [HttpPost]
        public ActionResult Login(AuthLogin form)
        {


            if (!ModelState.IsValid) {

                return View(form);
            }
           

            if(form.UserName.Length<5)
            {
                ModelState.AddModelError("UserName", "en az 5 karakter");
                return View(form);
            }

            FormsAuthentication.SetAuthCookie(form.UserName,true);

            return Content("Başarılı");
        }
    }
}