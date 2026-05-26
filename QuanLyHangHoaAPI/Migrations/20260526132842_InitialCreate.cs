using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyHangHoaAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HangHoas",
                columns: table => new
                {
                    MaHang = table.Column<string>(type: "TEXT", nullable: false),
                    TenHang = table.Column<string>(type: "TEXT", nullable: false),
                    DonViTinh = table.Column<string>(type: "TEXT", nullable: false),
                    SoLuongTon = table.Column<int>(type: "INTEGER", nullable: false),
                    DonGia = table.Column<double>(type: "REAL", nullable: false),
                    MaNCC = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangHoas", x => x.MaHang);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HangHoas");
        }
    }
}
