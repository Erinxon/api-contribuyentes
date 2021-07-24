using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiRnc.Migrations
{
    public partial class AddMigrationInitialCrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contribuyentes",
                columns: table => new
                {
                    Rnc = table.Column<string>(nullable: false),
                    RazonSocial = table.Column<string>(nullable: true),
                    NombreComercial = table.Column<string>(nullable: true),
                    ActividadEconomica = table.Column<string>(nullable: true),
                    Fecha = table.Column<string>(nullable: true),
                    Estatus = table.Column<string>(nullable: true),
                    RegimenDePagos = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contribuyentes", x => x.Rnc);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contribuyentes");
        }
    }
}
