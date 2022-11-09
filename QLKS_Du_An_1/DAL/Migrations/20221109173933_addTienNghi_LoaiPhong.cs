using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class addTienNghi_LoaiPhong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoaiPhong",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaLoaiPhong = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    TenLoaiPhong = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    SoGiuong = table.Column<int>(type: "int", nullable: false),
                    GiayNgay = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiPhong", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LoaiTienNghi",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaLoaiTienNghi = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    TenLoaiTienNghi = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiTienNghi", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietTienNghi",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaCTTienNghi = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    TenCTTienNghi = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    IDLoaiTienNghi = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietTienNghi", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ChiTietTienNghi_LoaiTienNghi_IDLoaiTienNghi",
                        column: x => x.IDLoaiTienNghi,
                        principalTable: "LoaiTienNghi",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietTienNghi_IDLoaiTienNghi",
                table: "ChiTietTienNghi",
                column: "IDLoaiTienNghi");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietTienNghi");

            migrationBuilder.DropTable(
                name: "LoaiPhong");

            migrationBuilder.DropTable(
                name: "LoaiTienNghi");
        }
    }
}
