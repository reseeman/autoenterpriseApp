//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoenterpriseApp.DataBaseFiles
{
    using System;
    using System.Collections.Generic;
    
    public partial class transport
    {
        public int idTransport { get; set; }
        public string mileageTransport { get; set; }
        public Nullable<System.DateTime> dateOfReceiptTransport { get; set; }
        public Nullable<System.DateTime> dateOfDeductionTransport { get; set; }
        public string brandTransport { get; set; }
        public int idDriver { get; set; }
        public int idTransportType { get; set; }
        public int idDestination { get; set; }
    
        public virtual destinations destinations { get; set; }
        public virtual drivers drivers { get; set; }
        public virtual transport_type transport_type { get; set; }
    }
}
