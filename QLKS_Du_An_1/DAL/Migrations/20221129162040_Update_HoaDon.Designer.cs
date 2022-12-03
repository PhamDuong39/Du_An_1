﻿// <auto-generated />
using System;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(QLKS_DA1_DbContext))]
    [Migration("20221129162040_Update_HoaDon")]
    partial class Update_HoaDon
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DAL.Models.ChiTietPhieuThue", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdPhieuThue")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdPhong")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime")
                        .HasColumnName("NgayBatDau");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime")
                        .HasColumnName("NgayKetThuc");

                    b.HasKey("ID");

                    b.HasIndex("IdPhieuThue");

                    b.HasIndex("IdPhong");

                    b.ToTable("CTPhieuThue", (string)null);
                });

            modelBuilder.Entity("DAL.Models.ChiTietTienNghi", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDLoaiTienNghi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdPhong")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaCTTienNghi")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MaCTTienNghi");

                    b.Property<string>("TenCTTienNghi")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("TenCTTienNghi");

                    b.HasKey("ID");

                    b.HasIndex("IDLoaiTienNghi");

                    b.HasIndex("IdPhong");

                    b.HasIndex("MaCTTienNghi")
                        .IsUnique();

                    b.ToTable("ChiTietTienNghi", (string)null);
                });

            modelBuilder.Entity("DAL.Models.ChucVu", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaCV")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MaCV");

                    b.Property<string>("TenCV")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TenCV");

                    b.HasKey("ID");

                    b.HasIndex("MaCV")
                        .IsUnique();

                    b.ToTable("ChucVu", (string)null);
                });

            modelBuilder.Entity("DAL.Models.DichVu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Gia")
                        .HasColumnType("int")
                        .HasColumnName("Gia ");

                    b.Property<Guid>("IDLoaiDichVu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaDichVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MaDichVu");

                    b.Property<string>("TenDichVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("TenDichVu");

                    b.HasKey("Id");

                    b.HasIndex("IDLoaiDichVu");

                    b.HasIndex("MaDichVu")
                        .IsUnique();

                    b.ToTable("DichVu", (string)null);
                });

            modelBuilder.Entity("DAL.Models.HoaDon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdCTPhieuThue")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaHD")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MaHD");

                    b.Property<DateTime>("NgayTT")
                        .HasColumnType("datetime")
                        .HasColumnName("NgayTT");

                    b.Property<DateTime>("NgayTaoHD")
                        .HasColumnType("datetime")
                        .HasColumnName("NgayTaoHD");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int")
                        .HasColumnName("TrangThai");

                    b.HasKey("Id");

                    b.HasIndex("IdCTPhieuThue")
                        .IsUnique();

                    b.HasIndex("MaHD")
                        .IsUnique();

                    b.ToTable("HoaDon", (string)null);
                });

            modelBuilder.Entity("DAL.Models.HoaDonChiTiet", b =>
                {
                    b.Property<Guid>("IdHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdDichVu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DonGia")
                        .HasColumnType("int")
                        .HasColumnName("DonGia");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int")
                        .HasColumnName("SoLuong");

                    b.HasKey("IdHoaDon", "IdDichVu");

                    b.HasIndex("IdDichVu");

                    b.ToTable("HoaDonChiTiet", (string)null);
                });

            modelBuilder.Entity("DAL.Models.KhachHang", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CCCD")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)")
                        .HasColumnName("CCCD");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("DiaChi");

                    b.Property<int>("GioiTinh")
                        .HasColumnType("int")
                        .HasColumnName("GioiTinh");

                    b.Property<string>("HovaTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("HoTen");

                    b.Property<string>("MaKH")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MaKH");

                    b.Property<string>("QuocTich")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("QuocTich");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)")
                        .HasColumnName("SDT");

                    b.HasKey("ID");

                    b.HasIndex("MaKH")
                        .IsUnique();

                    b.ToTable("KhachHang", (string)null);
                });

            modelBuilder.Entity("DAL.Models.LoaiDichVu", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaLoaiDichVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MaLoaiDichVu");

                    b.Property<string>("TenLoaiDichVu")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("TenLoaiDichVu");

                    b.HasKey("ID");

                    b.HasIndex("MaLoaiDichVu")
                        .IsUnique();

                    b.ToTable("LoaiDichVu", (string)null);
                });

            modelBuilder.Entity("DAL.Models.LoaiPhong", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("GiaNgay")
                        .HasColumnType("int")
                        .HasColumnName("GiayNgay");

                    b.Property<string>("MaLoaiPhong")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MaLoaiPhong");

                    b.Property<int>("SoGiuong")
                        .HasColumnType("int")
                        .HasColumnName("SoGiuong");

                    b.Property<string>("TenLoaiPhong")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("TenLoaiPhong");

                    b.HasKey("ID");

                    b.HasIndex("MaLoaiPhong")
                        .IsUnique();

                    b.ToTable("LoaiPhong", (string)null);
                });

            modelBuilder.Entity("DAL.Models.LoaiTienNghi", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaLoaiTienNghi")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MaLoaiTienNghi");

                    b.Property<string>("TenLoaiTienNghi")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("TenLoaiTienNghi");

                    b.HasKey("ID");

                    b.HasIndex("MaLoaiTienNghi")
                        .IsUnique();

                    b.ToTable("LoaiTienNghi", (string)null);
                });

            modelBuilder.Entity("DAL.Models.NhanVien", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CCCD")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)")
                        .HasColumnName("CCCD");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("DiaChi");

                    b.Property<int>("GioiTinh")
                        .HasColumnType("int")
                        .HasColumnName("GioiTinh");

                    b.Property<Guid>("IDCv")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IDCv");

                    b.Property<int>("Luong")
                        .HasColumnType("int")
                        .HasColumnName("Luong");

                    b.Property<string>("MaNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MaNV");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime")
                        .HasColumnName("NgaySinh");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)")
                        .HasColumnName("SDT");

                    b.Property<string>("TenNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TenNV");

                    b.HasKey("ID");

                    b.HasIndex("IDCv");

                    b.HasIndex("MaNV")
                        .IsUnique();

                    b.ToTable("NhanVien", (string)null);
                });

            modelBuilder.Entity("DAL.Models.PhieuThue", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdKH")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdNV")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("MaPhieuThue")
                        .HasColumnType("int")
                        .HasColumnName("MaPhieuThue");

                    b.Property<DateTime>("NgayLapPhieu")
                        .HasColumnType("datetime")
                        .HasColumnName("NgayLapPhieu");

                    b.HasKey("ID");

                    b.HasIndex("IdKH");

                    b.HasIndex("IdNV");

                    b.ToTable("PhieuThue", (string)null);
                });

            modelBuilder.Entity("DAL.Models.Phong", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDLoaiPhong")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaPhong")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MaPhong");

                    b.Property<int>("TinhTrang")
                        .HasColumnType("int")
                        .HasColumnName("TinhTrang");

                    b.HasKey("Id");

                    b.HasIndex("IDLoaiPhong");

                    b.HasIndex("MaPhong")
                        .IsUnique();

                    b.ToTable("Phong", (string)null);
                });

            modelBuilder.Entity("DAL.Models.TaiKhoan", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CapDoQuyen")
                        .HasColumnType("int")
                        .HasColumnName("CapDoQuyen");

                    b.Property<Guid?>("IDNv")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MatKhau");

                    b.Property<string>("TenTaiKhoan")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("TenTaiKhoan");

                    b.HasKey("ID");

                    b.HasIndex("IDNv")
                        .IsUnique()
                        .HasFilter("[IDNv] IS NOT NULL");

                    b.HasIndex("TenTaiKhoan")
                        .IsUnique();

                    b.ToTable("TaiKhoan", (string)null);
                });

            modelBuilder.Entity("DAL.Models.ChiTietPhieuThue", b =>
                {
                    b.HasOne("DAL.Models.PhieuThue", "PhieuThue")
                        .WithMany()
                        .HasForeignKey("IdPhieuThue")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Models.Phong", "Phong")
                        .WithMany()
                        .HasForeignKey("IdPhong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PhieuThue");

                    b.Navigation("Phong");
                });

            modelBuilder.Entity("DAL.Models.ChiTietTienNghi", b =>
                {
                    b.HasOne("DAL.Models.LoaiTienNghi", "LoaiTienNghi")
                        .WithMany()
                        .HasForeignKey("IDLoaiTienNghi")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Models.Phong", "Phong")
                        .WithMany()
                        .HasForeignKey("IdPhong");

                    b.Navigation("LoaiTienNghi");

                    b.Navigation("Phong");
                });

            modelBuilder.Entity("DAL.Models.DichVu", b =>
                {
                    b.HasOne("DAL.Models.LoaiDichVu", "LoaiDichVu")
                        .WithMany()
                        .HasForeignKey("IDLoaiDichVu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiDichVu");
                });

            modelBuilder.Entity("DAL.Models.HoaDon", b =>
                {
                    b.HasOne("DAL.Models.ChiTietPhieuThue", "ChiTietPhieuThue")
                        .WithOne("HoaDon")
                        .HasForeignKey("DAL.Models.HoaDon", "IdCTPhieuThue")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChiTietPhieuThue");
                });

            modelBuilder.Entity("DAL.Models.HoaDonChiTiet", b =>
                {
                    b.HasOne("DAL.Models.DichVu", "DichVu")
                        .WithMany()
                        .HasForeignKey("IdDichVu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Models.HoaDon", "HoaDon")
                        .WithMany()
                        .HasForeignKey("IdHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DichVu");

                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("DAL.Models.NhanVien", b =>
                {
                    b.HasOne("DAL.Models.ChucVu", "ChucVu")
                        .WithMany()
                        .HasForeignKey("IDCv")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChucVu");
                });

            modelBuilder.Entity("DAL.Models.PhieuThue", b =>
                {
                    b.HasOne("DAL.Models.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("IdKH");

                    b.HasOne("DAL.Models.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("IdNV");

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("DAL.Models.Phong", b =>
                {
                    b.HasOne("DAL.Models.LoaiPhong", "LoaiPhong")
                        .WithMany()
                        .HasForeignKey("IDLoaiPhong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiPhong");
                });

            modelBuilder.Entity("DAL.Models.TaiKhoan", b =>
                {
                    b.HasOne("DAL.Models.NhanVien", "NhanVien")
                        .WithOne("TaiKhoan")
                        .HasForeignKey("DAL.Models.TaiKhoan", "IDNv");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("DAL.Models.ChiTietPhieuThue", b =>
                {
                    b.Navigation("HoaDon")
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Models.NhanVien", b =>
                {
                    b.Navigation("TaiKhoan")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
