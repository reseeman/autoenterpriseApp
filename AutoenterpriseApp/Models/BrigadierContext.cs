using System.Data.Entity;

namespace AutoenterpriseApp.Models
{
    public class BrigadierContext : DbContext
    {
        public BrigadierContext() : base("DefaultConnection")
        {

        }
        public DbSet<Brigadier> brigadiers { get; set; }
    }
}
