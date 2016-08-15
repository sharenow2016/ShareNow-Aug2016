using ShareImmediate.DataEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShareImmediate.Controllers
{
    public class ShareController : Controller
    {
        // GET: Share
        public ActionResult Index()
        {
            CommonEntities db = new CommonEntities();
            var ViewModel = new ViewModels.ShareVM();

            ViewBag.UserName = new SelectList(db.Users, "id", "name");
            return View(ViewModel);
        }
    }
}