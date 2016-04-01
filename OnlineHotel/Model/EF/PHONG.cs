namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHONG")]
    public partial class PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONG()
        {
            PHIEUTHUEPHONGs = new HashSet<PHIEUTHUEPHONG>();
        }

        [Key]
        public int MaPhong { get; set; }

        public int? MaLP { get; set; }

        [StringLength(50)]
        public string TenPhong { get; set; }

        public bool? TinhTrang { get; set; }

        public virtual LOAIPHONG LOAIPHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTHUEPHONG> PHIEUTHUEPHONGs { get; set; }
    }
}
