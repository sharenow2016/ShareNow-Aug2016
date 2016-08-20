using ShareImmediate.DataEntities;
using ShareImmediate.ViewModels;
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

            ViewModel.GroupMembers = (from r in db.Users.AsEnumerable() select r).ToList();
            return View(ViewModel);
        }

        [HttpPost]
        public ActionResult Index(GroupVM model)
        {
            CommonEntities db = new CommonEntities();
            var ViewModel = new ViewModels.GroupVM();
            var NewGroup = new DataEntities.Group();
            foreach (var row in model.SelectedMembers)
            {
                NewGroup.UserId = Int32.Parse(row);
                NewGroup.GroupName = model.GroupName;
                db.Group.Add(NewGroup);
                db.SaveChanges();
            }
            ViewModel.GroupMembers = (from r in db.Users.AsEnumerable() select r).ToList();
            ViewModel.Message = "Data Inserted successfully...............";
            return View("Index", ViewModel);
        }
    }
}