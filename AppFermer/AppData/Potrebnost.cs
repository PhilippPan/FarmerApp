//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppFermer.AppData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Potrebnost
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Potrebnost()
        {
            this.ZayavkiFermer = new HashSet<ZayavkiFermer>();
        }
    
        public int Id { get; set; }
        public string Nazvanie { get; set; }
        public decimal Cena { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZayavkiFermer> ZayavkiFermer { get; set; }
    }
}