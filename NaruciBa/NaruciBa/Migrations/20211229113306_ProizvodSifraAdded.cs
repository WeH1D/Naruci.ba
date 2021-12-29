using Microsoft.EntityFrameworkCore.Migrations;

namespace NaruciBa.Migrations
{
    public partial class ProizvodSifraAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sifra",
                table: "Proizvod",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sifra",
                table: "Proizvod");
        }
    }
}
