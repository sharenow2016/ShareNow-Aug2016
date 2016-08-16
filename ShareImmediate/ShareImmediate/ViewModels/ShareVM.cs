using ShareImmediate.DataEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShareImmediate.ViewModels
{
    public class ShareVM
    {
        public int ShareAmount { get; set; }
        public string Category { get; set; }
        public string[] SelectedUsers { get; set; }
        public IEnumerable<Users> AvailableUsers { get; set; }
        public string Message { get; set; }
    }
}