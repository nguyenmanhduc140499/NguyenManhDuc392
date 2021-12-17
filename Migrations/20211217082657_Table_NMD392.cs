using Microsoft.EntityFrameworkCore.Migrations;

namespace NguyenManhDuc392.Migrations
{
    public partial class Table_NMD392 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NMD392",
                columns: table => new
                {
                    NMDID = table.Column<string>(type: "TEXT", nullable: false),
                    NMDName = table.Column<string>(type: "TEXT", nullable: true),
                    NMDGende = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NMD392", x => x.NMDID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NMD392");
        }
    }
}
