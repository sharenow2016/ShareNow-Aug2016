using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using ShareImmediate.ViewModels;
using ShareImmediate.DataEntities;

namespace ShareImmediate.Controllers
{
    public class PayController : Controller
    {
        
        public ActionResult Index()
        {
            CommonEntities db = new CommonEntities();
            var ViewModel = new ViewModels.PayVM();
            
            ViewBag.UserName = new SelectList(db.Users, "id", "name");
            return View(ViewModel);
        }
    }
}