namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUTHUEPHONG")]
    public partial class PHIEUTHUEPHONG
    {
        [Key]
        public int MaPT { get; set; }

        public int? MaKH { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayBatDauThue { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayLapPhieu { get; set; }

        public int? MaPhong { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
