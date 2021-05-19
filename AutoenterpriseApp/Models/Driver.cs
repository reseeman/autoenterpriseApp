using System;
using System.ComponentModel.DataAnnotations;

namespace AutoenterpriseApp.Models
{
    public class Driver
    {
        [Key]
        public int idDriver { get; set; }

        public string nameDriver { get; set; }

        public int idBrigade { get; set; }
    }
}
