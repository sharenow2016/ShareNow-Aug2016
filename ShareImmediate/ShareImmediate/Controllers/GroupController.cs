using ShareImmediate.DataEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShareImmediate.Controllers
{
    public class GroupController : Controller
    {
        // GET: Group
        public ActionResult Index()
        {
            CommonEntities db = new CommonEntities();
            var ViewModel = new ViewModels.GroupVM();

            ViewBag.GroupMembersList = new SelectList(db.Users, "id", "name");
            return View(ViewModel);
        }
    }
}