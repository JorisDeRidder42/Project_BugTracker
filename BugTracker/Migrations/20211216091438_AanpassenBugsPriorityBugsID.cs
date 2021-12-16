using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class AanpassenBugsPriorityBugsID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BugsPriority_Bugs_BugsID",
                schema: "BugTracker",
                table: "BugsPriority");

            migrationBuilder.DropIndex(
                name: "IX_BugsPriority_BugsID",
                schema: "BugTracker",
                table: "BugsPriority");

            migrationBuilder.DropColumn(
                name: "BugsID",
                schema: "BugTracker",
                table: "BugsPriority");

            migrationBuilder.CreateIndex(
                name: "IX_Bugs_BugsPriorityID",
                schema: "BugTracker",
                table: "Bugs",
                column: "BugsPriorityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_BugsPriority_BugsPriorityID",
                schema: "BugTracker",
                table: "Bugs",
                column: "BugsPriorityID",
                principalSchema: "BugTracker",
                principalTable: "BugsPriority",
                principalColumn: "BugsPriorityID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_BugsPriority_BugsPriorityID",
                schema: "BugTracker",
                table: "Bugs");

            migrationBuilder.DropIndex(
                name: "IX_Bugs_BugsPriorityID",
                schema: "BugTracker",
                table: "Bugs");

            migrationBuilder.AddColumn<int>(
                name: "BugsID",
                schema: "BugTracker",
                table: "BugsPriority",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BugsPriority_BugsID",
                schema: "BugTracker",
                table: "BugsPriority",
                column: "BugsID");

            migrationBuilder.AddForeignKey(
                name: "FK_BugsPriority_Bugs_BugsID",
                schema: "BugTracker",
                table: "BugsPriority",
                column: "BugsID",
                principalSchema: "BugTracker",
                principalTable: "Bugs",
                principalColumn: "BugsID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
