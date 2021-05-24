using System.ComponentModel.DataAnnotations;

namespace AutoenterpriseApp.Models
{
    public class Landwork
    {
        [Key]
        public int idLandwork { get; set; }

        public string nameLandwork { get; set; }

        public int idMaster { get; set; }
    }
}
