using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class TeamToegevoegddb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                schema: "BugTracker",
                columns: table => new
                {
                    TeamID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamNaam = table.Column<string>(nullable: true),
                    AantalPersonen = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamID);
                    table.ForeignKey(
                        name: "FK_Teams_User_UserID",
                        column: x => x.UserID,
                        principalSchema: "BugTracker",
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeamProject",
                columns: table => new
                {
                    TeamProjectID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(nullable: false),
                    TeamID = table.Column<int>(nullable: false),
                    ProjectsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamProject", x => x.TeamProjectID);
                    table.ForeignKey(
                        name: "FK_TeamProject_Projects_ProjectsID",
                        column: x => x.ProjectsID,
                        principalSchema: "BugTracker",
                        principalTable: "Projects",
                        principalColumn: "ProjectsID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamProject_Teams_TeamID",
                        column: x => x.TeamID,
                        principalSchema: "BugTracker",
                        principalTable: "Teams",
                        principalColumn: "TeamID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeamProject_ProjectsID",
                table: "TeamProject",
                column: "ProjectsID");

            migrationBuilder.CreateIndex(
                name: "IX_TeamProject_TeamID",
                table: "TeamProject",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_UserID",
                schema: "BugTracker",
                table: "Teams",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamProject");

            migrationBuilder.DropTable(
                name: "Teams",
                schema: "BugTracker");
        }
    }
}
