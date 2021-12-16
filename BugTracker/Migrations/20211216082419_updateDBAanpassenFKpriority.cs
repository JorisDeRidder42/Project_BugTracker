using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class updateDBAanpassenFKpriority : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BugsPriorityId",
                schema: "BugTracker",
                table: "Bugs",
                newName: "BugsPriorityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BugsPriorityID",
                schema: "BugTracker",
                table: "Bugs",
                newName: "BugsPriorityId");
        }
    }
}
