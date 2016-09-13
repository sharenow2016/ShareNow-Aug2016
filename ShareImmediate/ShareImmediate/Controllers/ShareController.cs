using ShareImmediate.DataEntities;
using ShareImmediate.ViewModels;
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

            ViewModel.AvailableUsers = (from r in db.Users.AsEnumerable() select r).ToList();
            return View(ViewModel);
        }
        [HttpPost]
        public ActionResult Index(ShareVM model)
        {
            CommonEntities db = new CommonEntities();
            var ViewModel = new ViewModels.ShareVM();
            var NewShare = new DataEntities.ShareDetails();
            foreach (var row in model.SelectedUsers)
            {
                NewShare.USerID = Int32.Parse(row);
                NewShare.Amount = model.ShareAmount;
                NewShare.Category = model.Category;
                db.ShareDetails.Add(NewShare);
                db.SaveChanges();
            }
            ViewModel.AvailableUsers = (from r in db.Users.AsEnumerable() select r).ToList();
            ViewModel.Message = "Data Inserted successfully...............";
            return View("Index", ViewModel);
        }
    }
}