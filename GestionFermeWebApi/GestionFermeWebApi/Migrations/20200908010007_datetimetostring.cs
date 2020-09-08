using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionFermeWebApi.Migrations
{
    public partial class datetimetostring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "dateAdhesion",
                table: "Ferme",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "dateAdhesion",
                table: "Ferme",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
