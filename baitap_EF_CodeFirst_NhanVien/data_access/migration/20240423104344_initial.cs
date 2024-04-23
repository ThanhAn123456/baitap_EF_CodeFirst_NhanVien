using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace baitap_EF_CodeFirst_NhanVien.data_access.migration
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CongTy",
                columns: table => new
                {
                    MaCongTy = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenCongTy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongTy", x => x.MaCongTy);
                });

            migrationBuilder.CreateTable(
                name: "PhongBan",
                columns: table => new
                {
                    MaPB = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenPB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaCongTy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CongTyMaCongTy = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongBan", x => x.MaPB);
                    table.ForeignKey(
                        name: "FK_PhongBan_CongTy_CongTyMaCongTy",
                        column: x => x.CongTyMaCongTy,
                        principalTable: "CongTy",
                        principalColumn: "MaCongTy");
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tuoi = table.Column<int>(type: "int", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaPB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhongBanMaPB = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaNV);
                    table.ForeignKey(
                        name: "FK_NhanVien_PhongBan_PhongBanMaPB",
                        column: x => x.PhongBanMaPB,
                        principalTable: "PhongBan",
                        principalColumn: "MaPB",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_PhongBanMaPB",
                table: "NhanVien",
                column: "PhongBanMaPB");

            migrationBuilder.CreateIndex(
                name: "IX_PhongBan_CongTyMaCongTy",
                table: "PhongBan",
                column: "CongTyMaCongTy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "PhongBan");

            migrationBuilder.DropTable(
                name: "CongTy");
        }
    }
}
