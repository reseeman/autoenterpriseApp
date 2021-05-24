using System.Data.Entity;

namespace AutoenterpriseApp.Models
{
    public class DestinationContext : DbContext
    {
        public DestinationContext() : base("DefaultConnection")
        {

        }
        public DbSet<Destination> destinations { get; set; }
    }
}
