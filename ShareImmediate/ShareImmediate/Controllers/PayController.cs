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
            ViewModel.AvailableUsers = (from r in db.Users.AsEnumerable() select r).ToList();
            return View(ViewModel);
        }
        [HttpPost]
        public ActionResult Index(PayVM model)
        {
            CommonEntities db = new CommonEntities();
            var ViewModel = new ViewModels.PayVM();
            var NewPayment = new DataEntities.Payment();
            foreach(var row in model.SelectedUser)
            {
                NewPayment.UserId = Int32.Parse(row);
                NewPayment.Amount = model.PayAmount;
                db.Payment.Add(NewPayment);
                db.SaveChanges();
            }
            ViewModel.AvailableUsers = (from r in db.Users.AsEnumerable() select r).ToList();
            ViewModel.Message = "Data Inserted successfully...............";
            return View("Index",ViewModel);
        }

    }
}