using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShareImmediate.DataEntities
{
    public class Payment
    {
        
        public int id { get; set; }
        public int Amount { get; set; }
        public int UserId { get; set; }
    }
}