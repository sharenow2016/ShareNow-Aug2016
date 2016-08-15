using ShareImmediate.DataEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShareImmediate.ViewModels
{
    public class GroupVM
    {
        public string GroupName { get; set; }
        public IEnumerable<Users> GroupMembers { get; set; }
        public string Message { get; set; }
    }
}