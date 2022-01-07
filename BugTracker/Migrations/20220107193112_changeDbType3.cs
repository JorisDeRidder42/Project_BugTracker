using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class changeDbType3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BugsType",
                schema: "BugTracker",
                table: "Bugs");

            migrationBuilder.AddColumn<string>(
                name: "BugType",
                schema: "BugTracker",
                table: "Bugs",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BugType",
                schema: "BugTracker",
                table: "Bugs");

            migrationBuilder.AddColumn<string>(
                name: "BugsType",
                schema: "BugTracker",
                table: "Bugs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
