using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShareImmediate.DataEntities
{
    public class Group
    {
        public int id { get; set; }
        public string GroupName { get; set; }
        public int UserId { get; set; }
    }
}