using ShareImmediate.DataEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShareImmediate.ViewModels
{
    public class PayVM
    {
        [Required]
        [Display(Name = "Amount")]
        public int PayAmount { get; set; }
        public string[] SelectedUser { get; set; }


        //public string User { get; set; }

        public IEnumerable<Users> AvailableUsers { get; set; }

        public string Message { get; set; }
    }
}