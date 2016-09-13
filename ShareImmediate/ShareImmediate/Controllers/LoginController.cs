using ShareImmediate.ViewModels;
using ShareImmediate.DataEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ShareImmediate.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginVM model,string returnUrl)
        {
            CommonEntities db = new CommonEntities();
            string UserName = model.UserName;
            string Password = model.Password;

            bool userValid = db.UserDetails.Any(user => user.username == UserName && user.password == Password);

            // User found in the database
            if (userValid)
            {

                //FormsAuthentication.SetAuthCookie(UserName, false);
                if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                    && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                {
                    return RedirectToAction(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                    }
                }
            else
            {
                ModelState.AddModelError("", "The user name or password provided is incorrect.");
            }
            return View();
        }

    }
}