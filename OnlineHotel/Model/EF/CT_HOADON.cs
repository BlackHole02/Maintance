namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_HOADON
    {
        [Key]
        [Column(Order = 0)]
        public int MaHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPT { get; set; }

        public int? SoNgayThue { get; set; }

        public double? ThanhTien { get; set; }

        public virtual HOADON HOADON { get; set; }
    }
}
