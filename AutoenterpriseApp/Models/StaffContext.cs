using System.Data.Entity;

namespace AutoenterpriseApp.Models
{
    public class StaffContext : DbContext
    {
        public StaffContext() : base("DefaultConnection")
        {

        }
        public DbSet<Staff> staffs { get; set; }
    }
}
