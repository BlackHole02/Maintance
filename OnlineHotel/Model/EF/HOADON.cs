namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            CT_HOADON = new HashSet<CT_HOADON>();
        }

        [Key]
        public int MaHD { get; set; }

        public int? MaKH { get; set; }

        public double? TongTien { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayLap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HOADON> CT_HOADON { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
