using Housing.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing.DataModel
{
    public class HousingContext : DbContext
    {
        public DbSet<CodePrefix> CodePrefix { get; set; }
        public DbSet<SystemUser> SystemUser { get; set; }
        public DbSet<PropertyType> PropertyType { get; set; }
        public DbSet<Property> Property { get; set; }
        public DbSet<Buyer> Buyer { get; set; }
        public DbSet<Agent> Agent { get; set; }
        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<PropertyAgent> PropertyAgent { get; set; }
        public DbSet<PropertyBuyer> PropertyBuyer { get; set; }
        public DbSet<PropertyVendor> PropertyVendor { get; set; }
    }
}