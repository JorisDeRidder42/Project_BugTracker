using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class changeDb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_ApplicationUser_ApplicationUserId1",
                schema: "BugTracker",
                table: "Bugs");

            migrationBuilder.DropIndex(
                name: "IX_Bugs_ApplicationUserId1",
                schema: "BugTracker",
                table: "Bugs");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                schema: "BugTracker",
                table: "Bugs");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                schema: "BugTracker",
                table: "Bugs",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Bugs_ApplicationUserId",
                schema: "BugTracker",
                table: "Bugs",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_ApplicationUser_ApplicationUserId",
                schema: "BugTracker",
                table: "Bugs",
                column: "ApplicationUserId",
                principalSchema: "BugTracker",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_ApplicationUser_ApplicationUserId",
                schema: "BugTracker",
                table: "Bugs");

            migrationBuilder.DropIndex(
                name: "IX_Bugs_ApplicationUserId",
                schema: "BugTracker",
                table: "Bugs");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                schema: "BugTracker",
                table: "Bugs",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                schema: "BugTracker",
                table: "Bugs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bugs_ApplicationUserId1",
                schema: "BugTracker",
                table: "Bugs",
                column: "ApplicationUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_ApplicationUser_ApplicationUserId1",
                schema: "BugTracker",
                table: "Bugs",
                column: "ApplicationUserId1",
                principalSchema: "BugTracker",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
