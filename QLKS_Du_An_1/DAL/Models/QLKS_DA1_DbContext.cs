﻿using Microsoft.EntityFrameworkCore;
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

                .UseSqlServer("Data Source=DESKTOP-H6UFHDN\\SQLEXPRESS;Initial Catalog=QLKS_DuAn1;Persist Security Info=True;User ID=phuongmvph27860;Password=123"));
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
