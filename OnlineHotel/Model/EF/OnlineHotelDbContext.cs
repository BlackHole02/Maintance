namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OnlineHotelDbContext : DbContext
    {
        public OnlineHotelDbContext()
            : base("name=OnlineHotelDbContext")
        {
        }

        public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public virtual DbSet<CT_HOADON> CT_HOADON { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LOAIKHACHHANG> LOAIKHACHHANGs { get; set; }
        public virtual DbSet<LOAIPHONG> LOAIPHONGs { get; set; }
        public virtual DbSet<PHIEUTHUEPHONG> PHIEUTHUEPHONGs { get; set; }
        public virtual DbSet<PHONG> PHONGs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.UserName)
                .IsFixedLength();

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CT_HOADON)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);
        }
    }
}
