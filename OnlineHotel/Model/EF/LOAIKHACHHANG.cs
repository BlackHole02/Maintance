namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIKHACHHANG")]
    public partial class LOAIKHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIKHACHHANG()
        {
            KHACHHANGs = new HashSet<KHACHHANG>();
        }

        [Key]
        public int MaLoaiKH { get; set; }

        [StringLength(50)]
        public string TenLoaiKH { get; set; }

        public double? HeSo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHACHHANG> KHACHHANGs { get; set; }
    }
}
