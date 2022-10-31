using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class NullableServiceBlogModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_BlogDetails_BlogDetailId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_ServiceDetails_ServiceDetailId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_ServiceDetailId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_BlogDetailId",
                table: "Blogs");

            migrationBuilder.AlterColumn<int>(
                name: "ServiceDetailId",
                table: "Services",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BlogDetailId",
                table: "Blogs",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ServiceDetailId",
                table: "Services",
                column: "ServiceDetailId",
                unique: true,
                filter: "[ServiceDetailId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_BlogDetailId",
                table: "Blogs",
                column: "BlogDetailId",
                unique: true,
                filter: "[BlogDetailId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_BlogDetails_BlogDetailId",
                table: "Blogs",
                column: "BlogDetailId",
                principalTable: "BlogDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_ServiceDetails_ServiceDetailId",
                table: "Services",
                column: "ServiceDetailId",
                principalTable: "ServiceDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_BlogDetails_BlogDetailId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_ServiceDetails_ServiceDetailId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_ServiceDetailId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_BlogDetailId",
                table: "Blogs");

            migrationBuilder.AlterColumn<int>(
                name: "ServiceDetailId",
                table: "Services",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BlogDetailId",
                table: "Blogs",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Services_ServiceDetailId",
                table: "Services",
                column: "ServiceDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_BlogDetailId",
                table: "Blogs",
                column: "BlogDetailId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_BlogDetails_BlogDetailId",
                table: "Blogs",
                column: "BlogDetailId",
                principalTable: "BlogDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_ServiceDetails_ServiceDetailId",
                table: "Services",
                column: "ServiceDetailId",
                principalTable: "ServiceDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
