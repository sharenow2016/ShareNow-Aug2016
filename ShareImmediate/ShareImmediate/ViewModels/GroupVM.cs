using ShareImmediate.DataEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShareImmediate.ViewModels
{
    public class GroupVM
    {
        [Required]
        [Display(Name ="Group Name")]
        public string GroupName { get; set; }
        public string[] SelectedMembers { get; set; }
        [Required]
        [Display(Name ="Group Members")]
        public IEnumerable<Users> GroupMembers { get; set; }
        public string Message { get; set; }
    }
}