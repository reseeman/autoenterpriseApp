using System;
using System.ComponentModel.DataAnnotations;

namespace AutoenterpriseApp.Models
{
    public class Master
    {
        [Key]
        public int idMaster { get; set; }

        public string nameMaster { get; set; }

        public int idBrigadier { get; set; }
    }
}
