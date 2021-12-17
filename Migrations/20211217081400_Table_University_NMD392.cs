using Microsoft.EntityFrameworkCore.Migrations;

namespace NguyenManhDuc392.Migrations
{
    public partial class Table_University_NMD392 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UniversityNMD392",
                columns: table => new
                {
                    UniversityID = table.Column<string>(type: "TEXT", nullable: false),
                    UniversityName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversityNMD392", x => x.UniversityID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UniversityNMD392");
        }
    }
}
