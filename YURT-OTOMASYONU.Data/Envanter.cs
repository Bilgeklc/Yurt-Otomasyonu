//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YURT_OTOMASYONU.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Envanter
    {
        public int Id { get; set; }
        public Nullable<int> OgrenciId { get; set; }
        public Nullable<int> OdaId { get; set; }
        public Nullable<int> EnvanterId { get; set; }
    
        public virtual EnvanterListesi EnvanterListesi { get; set; }
        public virtual Oda Oda { get; set; }
        public virtual Ogrenci Ogrenci { get; set; }
    }
}
