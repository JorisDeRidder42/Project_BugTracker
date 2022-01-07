using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class changedContext2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_BugsPriority_BugsPriorityId",
                schema: "BugTracker",
                table: "Bugs");

            migrationBuilder.DropTable(
                name: "BugsPriority",
                schema: "BugTracker");

            migrationBuilder.DropIndex(
                name: "IX_Bugs_BugsPriorityId",
                schema: "BugTracker",
                table: "Bugs");

            migrationBuilder.DropColumn(
                name: "BugStatusId",
                schema: "BugTracker",
                table: "Bugs");

            migrationBuilder.DropColumn(
                name: "BugsPriorityId",
                schema: "BugTracker",
                table: "Bugs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BugStatusId",
                schema: "BugTracker",
                table: "Bugs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BugsPriorityId",
                schema: "BugTracker",
                table: "Bugs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BugsPriority",
                schema: "BugTracker",
                columns: table => new
                {
                    BugsPriorityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PriorityType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BugsPriority", x => x.BugsPriorityId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bugs_BugsPriorityId",
                schema: "BugTracker",
                table: "Bugs",
                column: "BugsPriorityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_BugsPriority_BugsPriorityId",
                schema: "BugTracker",
                table: "Bugs",
                column: "BugsPriorityId",
                principalSchema: "BugTracker",
                principalTable: "BugsPriority",
                principalColumn: "BugsPriorityId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
