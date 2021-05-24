using System.Data.Entity;

namespace AutoenterpriseApp.Models
{
    public class MasterContext : DbContext
    {
        public MasterContext() : base("DefaultConnection")
        {

        }
        public DbSet<Master> masters { get; set; }
    }
}
