using Microsoft.EntityFrameworkCore.Migrations;

namespace NaruciBa.Migrations
{
    public partial class trgovackiLanacSlikaPutanja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Slika",
                table: "TrgovackiLanac",
                newName: "SlikaPutanja");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SlikaPutanja",
                table: "TrgovackiLanac",
                newName: "Slika");
        }
    }
}
