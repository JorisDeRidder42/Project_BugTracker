using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class AanpassenIcollectionsDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Bugs_BugsID",
                schema: "BugTracker",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_BugsID",
                schema: "BugTracker",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                schema: "BugTracker",
                table: "Bugs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bugs_UserID",
                schema: "BugTracker",
                table: "Bugs",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_User_UserID",
                schema: "BugTracker",
                table: "Bugs",
                column: "UserID",
                principalSchema: "BugTracker",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_User_UserID",
                schema: "BugTracker",
                table: "Bugs");

            migrationBuilder.DropIndex(
                name: "IX_Bugs_UserID",
                schema: "BugTracker",
                table: "Bugs");

            migrationBuilder.DropColumn(
                name: "UserID",
                schema: "BugTracker",
                table: "Bugs");

            migrationBuilder.CreateIndex(
                name: "IX_User_BugsID",
                schema: "BugTracker",
                table: "User",
                column: "BugsID");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Bugs_BugsID",
                schema: "BugTracker",
                table: "User",
                column: "BugsID",
                principalSchema: "BugTracker",
                principalTable: "Bugs",
                principalColumn: "BugsID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
