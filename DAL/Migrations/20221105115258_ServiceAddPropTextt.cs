using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ServiceAddPropTextt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Text1",
                table: "Services",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text2",
                table: "Services",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text1",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Text2",
                table: "Services");
        }
    }
}
