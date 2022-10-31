using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class NoCommentServiceRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Services_ServiceId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ServiceId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Comments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ServiceId",
                table: "Comments",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Services_ServiceId",
                table: "Comments",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
