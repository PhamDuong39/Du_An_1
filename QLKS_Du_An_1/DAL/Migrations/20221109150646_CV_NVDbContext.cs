using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class CV_NVDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_ChucVu_ChucVuID",
                table: "NhanVien");

            migrationBuilder.DropIndex(
                name: "IX_NhanVien_ChucVuID",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "ChucVuID",
                table: "NhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IDCv",
                table: "NhanVien",
                column: "IDCv");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_ChucVu_IDCv",
                table: "NhanVien",
                column: "IDCv",
                principalTable: "ChucVu",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_ChucVu_IDCv",
                table: "NhanVien");

            migrationBuilder.DropIndex(
                name: "IX_NhanVien_IDCv",
                table: "NhanVien");

            migrationBuilder.AddColumn<Guid>(
                name: "ChucVuID",
                table: "NhanVien",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_ChucVuID",
                table: "NhanVien",
                column: "ChucVuID");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_ChucVu_ChucVuID",
                table: "NhanVien",
                column: "ChucVuID",
                principalTable: "ChucVu",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
