//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Stok_Takip.Models.EntitiyFreamwork
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Satışlar
    {
        public int id { get; set; }
        public Nullable<int> urun { get; set; }
        public Nullable<int> personel { get; set; }
        public Nullable<int> musteri { get; set; }
        public Nullable<decimal> fiyat { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    
        public virtual Tbl_Musteri Tbl_Musteri { get; set; }
        public virtual Tbl_Personel Tbl_Personel { get; set; }
        public virtual Tbl_Ürünler Tbl_Ürünler { get; set; }
    }
}
