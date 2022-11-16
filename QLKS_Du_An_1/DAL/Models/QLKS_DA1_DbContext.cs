using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class QLKS_DA1_DbContext : DbContext
    {
        public QLKS_DA1_DbContext()
        {

        }

        public QLKS_DA1_DbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // thuc hien rang buoc ket noi
            base.OnConfiguring(optionsBuilder
<<<<<<< HEAD
                .UseSqlServer("Data Source=LAPTOP-07LH20M4\\SQLEXPRESS02;Initial Catalog=QLKS_DuAn1_Lan2;Persist Security Info=True;User ID=DBSET;Password=123"));
=======
                .UseSqlServer("Data Source=DESKTOP-QQ18T65\\SQLEXPRESS;Initial Catalog=DuAn1;Integrated Security=True"));
>>>>>>> 7af78d7848b66a17078a50155b2e3b3e7e346f33
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // apply config cho cac model
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public virtual DbSet<ChiTietPhieuThue> ChiTietPhieuThues { get; set; }
        public virtual DbSet<ChiTietTienNghi> ChiTietTienNghis { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiDichVu> LoaiDichVus { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<LoaiTienNghi> LoaiTienNghis { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuThue> PhieuThues { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
    }
}
