using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace X20240408.AccesoADatos.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonasX",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ApellidoX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    FechaNacimientoX = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SueldoX = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StatusX = table.Column<int>(type: "int", nullable: false),
                    ComentarioX = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonasX", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonasX");
        }
    }
}
