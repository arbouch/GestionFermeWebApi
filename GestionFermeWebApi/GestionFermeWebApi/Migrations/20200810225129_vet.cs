using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionFermeWebApi.Migrations
{
    public partial class vet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "veterinaire",
                columns: table => new
                {
                    IDVet = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(nullable: true),
                    prenom = table.Column<string>(nullable: true),
                    num1 = table.Column<int>(nullable: false),
                    num2 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veterinaire", x => x.IDVet);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "veterinaire");
        }
    }
}
