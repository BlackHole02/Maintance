namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCOUNT")]
    public partial class ACCOUNT
    {
        [Required]
        [StringLength(10)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public int ID { get; set; }
    }
}
