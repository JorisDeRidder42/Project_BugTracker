using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class changedContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_BugStatus_BugStatusId",
                schema: "BugTracker",
                table: "Bugs");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamProject_Teams_TeamId",
                schema: "BugTracker",
                table: "TeamProject");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_ApplicationUser_ApplicationUserId",
                schema: "BugTracker",
                table: "Teams");

            migrationBuilder.DropTable(
                name: "BugStatus",
                schema: "BugTracker");

            migrationBuilder.DropIndex(
                name: "IX_Bugs_BugStatusId",
                schema: "BugTracker",
                table: "Bugs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teams",
                schema: "BugTracker",
                table: "Teams");

            migrationBuilder.RenameTable(
                name: "Teams",
                schema: "BugTracker",
                newName: "Team",
                newSchema: "BugTracker");

            migrationBuilder.RenameIndex(
                name: "IX_Teams_ApplicationUserId",
                schema: "BugTracker",
                table: "Team",
                newName: "IX_Team_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Team",
                schema: "BugTracker",
                table: "Team",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Team_ApplicationUser_ApplicationUserId",
                schema: "BugTracker",
                table: "Team",
                column: "ApplicationUserId",
                principalSchema: "BugTracker",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamProject_Team_TeamId",
                schema: "BugTracker",
                table: "TeamProject",
                column: "TeamId",
                principalSchema: "BugTracker",
                principalTable: "Team",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Team_ApplicationUser_ApplicationUserId",
                schema: "BugTracker",
                table: "Team");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamProject_Team_TeamId",
                schema: "BugTracker",
                table: "TeamProject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Team",
                schema: "BugTracker",
                table: "Team");

            migrationBuilder.RenameTable(
                name: "Team",
                schema: "BugTracker",
                newName: "Teams",
                newSchema: "BugTracker");

            migrationBuilder.RenameIndex(
                name: "IX_Team_ApplicationUserId",
                schema: "BugTracker",
                table: "Teams",
                newName: "IX_Teams_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teams",
                schema: "BugTracker",
                table: "Teams",
                column: "TeamId");

            migrationBuilder.CreateTable(
                name: "BugStatus",
                schema: "BugTracker",
                columns: table => new
                {
                    BugStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BugStatusType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BugStatus", x => x.BugStatusId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bugs_BugStatusId",
                schema: "BugTracker",
                table: "Bugs",
                column: "BugStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_BugStatus_BugStatusId",
                schema: "BugTracker",
                table: "Bugs",
                column: "BugStatusId",
                principalSchema: "BugTracker",
                principalTable: "BugStatus",
                principalColumn: "BugStatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamProject_Teams_TeamId",
                schema: "BugTracker",
                table: "TeamProject",
                column: "TeamId",
                principalSchema: "BugTracker",
                principalTable: "Teams",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_ApplicationUser_ApplicationUserId",
                schema: "BugTracker",
                table: "Teams",
                column: "ApplicationUserId",
                principalSchema: "BugTracker",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
