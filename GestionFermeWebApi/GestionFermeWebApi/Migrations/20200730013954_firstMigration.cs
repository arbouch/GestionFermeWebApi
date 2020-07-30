using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionFermeWebApi.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ferme",
                columns: table => new
                {
                    FermeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomFerme = table.Column<string>(nullable: true),
                    nomProp = table.Column<string>(nullable: true),
                    adresse = table.Column<string>(nullable: true),
                    numTelProp = table.Column<string>(nullable: true),
                    gouveroratFerme = table.Column<string>(nullable: true),
                    delegation = table.Column<string>(nullable: true),
                    dateAdhesion = table.Column<DateTime>(nullable: false),
                    cinPopr = table.Column<int>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ferme", x => x.FermeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ferme");
        }
    }
}
