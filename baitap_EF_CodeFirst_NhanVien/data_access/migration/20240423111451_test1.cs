using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace baitap_EF_CodeFirst_NhanVien.data_access.migration
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaCongTy",
                table: "PhongBan");

            migrationBuilder.DropColumn(
                name: "MaPB",
                table: "NhanVien");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MaCongTy",
                table: "PhongBan",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaPB",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
