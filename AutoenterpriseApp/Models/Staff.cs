using System.ComponentModel.DataAnnotations;

namespace AutoenterpriseApp.Models
{
    public class Staff
    {
        [Key]
        public int idStaff { get; set; }

        public string nameStaff { get; set; }

        public int idBrigade { get; set; }
    }
}
