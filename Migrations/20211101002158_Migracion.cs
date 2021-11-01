using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace P1_API1_Ismarlin_20180846.Migrations
{
    public partial class Migracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aportes",
                columns: table => new
                {
                    AporteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Persona = table.Column<string>(type: "TEXT", nullable: true),
                    Concepto = table.Column<string>(type: "TEXT", nullable: true),
                    Monto = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aportes", x => x.AporteId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aportes");
        }
    }
}
