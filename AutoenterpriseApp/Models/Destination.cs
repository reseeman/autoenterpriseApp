using System;
using System.ComponentModel.DataAnnotations;

namespace AutoenterpriseApp.Models
{
    public class Destination
    {
        [Key]
        public int idDestination { get; set; }

        public string departureDestination { get; set; }

        public string terminalDestination { get; set; }

        public string codeDestination { get; set; }
    }
}
