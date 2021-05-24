using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoenterpriseApp.Models
{
    public class LandchiefContext : DbContext
    {
        public LandchiefContext() : base("DefaultConnection")
        {

        }
        public DbSet<Landchief> landchiefs { get; set; }
    }
}
