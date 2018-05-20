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
    }
}