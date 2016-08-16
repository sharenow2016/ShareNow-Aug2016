using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShareImmediate.DataEntities
{
    public class ShareDetails
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public int USerID { get; set; }
        public int Amount { get; set; }
    }
}