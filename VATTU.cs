//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    
    public partial class VATTU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VATTU()
        {
            this.CTDONH = new HashSet<CTDONH>();
            this.CTPNHAP = new HashSet<CTPNHAP>();
            this.CTPXUAT = new HashSet<CTPXUAT>();
            this.TONKHO = new HashSet<TONKHO>();
        }
    
        public string MAVTU { get; set; }
        public string TENVTU { get; set; }
        public string DVTINH { get; set; }
        public Nullable<float> PHANTRAM { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDONH> CTDONH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPNHAP> CTPNHAP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPXUAT> CTPXUAT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TONKHO> TONKHO { get; set; }
    }
}