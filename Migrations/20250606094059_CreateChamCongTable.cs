using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyNhanVien.Migrations
{
    /// <inheritdoc />
    public partial class CreateChamCongTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "ChamCongs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TrangThai",
                table: "ChamCongs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
