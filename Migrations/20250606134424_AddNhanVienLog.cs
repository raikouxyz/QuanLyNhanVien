using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyNhanVien.Migrations
{
    /// <inheritdoc />
    public partial class AddNhanVienLog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NgayNghiViec",
                table: "NhanViens");

            migrationBuilder.CreateTable(
                name: "NhanVienLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiThaoTac = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NhanVienId = table.Column<int>(type: "int", nullable: false),
                    TenNhanVien = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NguoiThucHien = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ThoiGian = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoiDungThayDoi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVienLogs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NhanVienLogs");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayNghiViec",
                table: "NhanViens",
                type: "datetime2",
                nullable: true);
        }
    }
}
