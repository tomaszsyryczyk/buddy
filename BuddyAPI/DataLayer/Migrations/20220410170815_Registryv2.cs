using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class Registryv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "From",
                table: "Registry");

            migrationBuilder.RenameColumn(
                name: "To",
                table: "Registry",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Registry",
                newName: "To");

            migrationBuilder.AddColumn<string>(
                name: "From",
                table: "Registry",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
