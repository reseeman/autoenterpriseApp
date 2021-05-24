using System.Data.Entity;

namespace AutoenterpriseApp.Models
{
    public class RouteContext : DbContext
    {
        public RouteContext() : base("DefaultConnection")
        {

        }
        public DbSet<Route> routes { get; set; }
    }
}
