using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kaffee.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kaffeemaschine",
                columns: table => new
                {
                    Wasser = table.Column<double>(type: "REAL", nullable: false),
                    Bohnen = table.Column<double>(type: "REAL", nullable: false),
                    gesamtMengeKaffeeProduziert = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kaffeemaschine", x => x.Wasser);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kaffeemaschine");
        }
    }
}
