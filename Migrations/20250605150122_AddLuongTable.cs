using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyNhanVien.Migrations
{
    /// <inheritdoc />
    public partial class AddLuongTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Luongs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NhanVienId = table.Column<int>(type: "int", nullable: false),
                    Thang = table.Column<int>(type: "int", nullable: false),
                    Nam = table.Column<int>(type: "int", nullable: false),
                    LuongCoBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PhuCap = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KhauTru = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoNgayLamViec = table.Column<int>(type: "int", nullable: false),
                    SoNgayNghiPhep = table.Column<int>(type: "int", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Luongs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Luongs_NhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanViens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Luongs_NhanVienId",
                table: "Luongs",
                column: "NhanVienId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Luongs");
        }
    }
}
