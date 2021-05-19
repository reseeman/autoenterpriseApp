using System.Data.Entity;

namespace AutoenterpriseApp.Models
{
    public class DriverContext : DbContext
    {
        public DriverContext() : base("DefaultConnection")
        {

        }
        public DbSet<Driver> drivers { get; set; }
    }
}
