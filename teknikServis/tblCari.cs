//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace teknikServis
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCari
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCari()
        {
            this.tblFaturaBilgi = new HashSet<tblFaturaBilgi>();
            this.tblUrunHareket = new HashSet<tblUrunHareket>();
            this.tblUrunKabul = new HashSet<tblUrunKabul>();
        }
    
        public int ID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string IL { get; set; }
        public string ILCE { get; set; }
        public string Banka { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string Statu { get; set; }
        public string Adres { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblFaturaBilgi> tblFaturaBilgi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUrunHareket> tblUrunHareket { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUrunKabul> tblUrunKabul { get; set; }
    }
}
