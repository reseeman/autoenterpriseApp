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
    
    public partial class foremens
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public foremens()
        {
            this.landchiefs = new HashSet<landchiefs>();
        }
    
        public int idForemen { get; set; }
        public string nameForemen { get; set; }
        public int idMaster { get; set; }
    
        public virtual masters masters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<landchiefs> landchiefs { get; set; }
    }
}