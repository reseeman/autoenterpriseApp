using System;
using System.ComponentModel.DataAnnotations;

namespace AutoenterpriseApp.Models
{
    public class Brigadier
    {
        [Key]
        public int idBrigadier { get; set; }

        public string nameBrigadier { get; set; }

        public int idBrigade { get; set; }
    }
}
