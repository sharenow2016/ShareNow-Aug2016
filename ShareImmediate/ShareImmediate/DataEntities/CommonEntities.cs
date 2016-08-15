using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ShareImmediate.DataEntities
{
    public class CommonEntities : DbContext
    {
        public CommonEntities()
            : base("name=SIEntities")
        { }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
    }
}