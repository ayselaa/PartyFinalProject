using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class TeamNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_TeamDetails_TeamDetailId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_TeamDetailId",
                table: "Teams");

            migrationBuilder.AlterColumn<int>(
                name: "TeamDetailId",
                table: "Teams",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_TeamDetailId",
                table: "Teams",
                column: "TeamDetailId",
                unique: true,
                filter: "[TeamDetailId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_TeamDetails_TeamDetailId",
                table: "Teams",
                column: "TeamDetailId",
                principalTable: "TeamDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_TeamDetails_TeamDetailId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_TeamDetailId",
                table: "Teams");

            migrationBuilder.AlterColumn<int>(
                name: "TeamDetailId",
                table: "Teams",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_TeamDetailId",
                table: "Teams",
                column: "TeamDetailId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_TeamDetails_TeamDetailId",
                table: "Teams",
                column: "TeamDetailId",
                principalTable: "TeamDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
