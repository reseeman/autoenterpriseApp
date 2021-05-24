using System.ComponentModel.DataAnnotations;

namespace AutoenterpriseApp.Models
{
    public class Landchief
    {
        [Key]
        public int idLandchief { get; set; }

        public string nameLandchief { get; set; }

        public int idForemen { get; set; }
    }
}
