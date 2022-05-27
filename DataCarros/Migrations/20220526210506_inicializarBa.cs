using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataCarros.Migrations
{
    public partial class inicializarBa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Propietarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carros",
                table: "Carros");

            migrationBuilder.RenameTable(
                name: "Carros",
                newName: "Garaje");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Garaje",
                table: "Garaje",
                column: "serial");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Garaje",
                table: "Garaje");

            migrationBuilder.RenameTable(
                name: "Garaje",
                newName: "Carros");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carros",
                table: "Carros",
                column: "serial");

            migrationBuilder.CreateTable(
                name: "Propietarios",
                columns: table => new
                {
                    numero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marcaPreferida = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numeroCarros = table.Column<int>(type: "int", nullable: false),
                    sueldo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propietarios", x => x.numero);
                });
        }
    }
}
