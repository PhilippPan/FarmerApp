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
    
    public partial class Proizvodstvo
    {
        public int Id { get; set; }
        public int IdFermer { get; set; }
        public int IdProdukcia { get; set; }
        public System.DateTime DataPoseshenia { get; set; }
        public string Commentarii { get; set; }
    
        public virtual Fermer Fermer { get; set; }
        public virtual Produkcia Produkcia { get; set; }
    }
}
