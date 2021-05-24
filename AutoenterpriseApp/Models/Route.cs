using System;
using System.ComponentModel.DataAnnotations;

namespace AutoenterpriseApp.Models
{
    public class Route
    {
        [Key]
        public int idRoute { get; set; }

        public int mileageTransport { get; set; }

        public DateTime dateOfReceiptTransport { get; set; }

        public DateTime dateOfDeductionTransport { get; set; }

        public string brandTransport { get; set; }

        public int idDriver { get; set; }

        public int idTransportType { get; set; }

        public int idDestination { get; set; }
    }
}
