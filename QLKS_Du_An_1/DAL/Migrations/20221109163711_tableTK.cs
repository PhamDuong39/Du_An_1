using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class tableTK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenTaiKhoan = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    CapDoQuyen = table.Column<int>(type: "int", nullable: false),
                    IDNv = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TaiKhoan_NhanVien_IDNv",
                        column: x => x.IDNv,
                        principalTable: "NhanVien",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_IDNv",
                table: "TaiKhoan",
                column: "IDNv",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaiKhoan");
        }
    }
}
