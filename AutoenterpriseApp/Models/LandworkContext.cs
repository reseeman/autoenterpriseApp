using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoenterpriseApp.Models
{
    public class LandworkContext : DbContext
    {
        public LandworkContext() : base("DefaultConnection")
        {

        }
        public DbSet<Landwork> landworks { get; set; }
    }
}
