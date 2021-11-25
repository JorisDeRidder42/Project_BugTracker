using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BugsPriority",
                columns: table => new
                {
                    BugsPriorityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PriorityType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BugsPriority", x => x.BugsPriorityID);
                });

            migrationBuilder.CreateTable(
                name: "BugStatus",
                columns: table => new
                {
                    BugStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BugStatusType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BugStatus", x => x.BugStatusID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectBugs",
                columns: table => new
                {
                    ProjectBugsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectsID = table.Column<int>(nullable: false),
                    BugsID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectBugs", x => x.ProjectBugsID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectsAcces",
                columns: table => new
                {
                    ProjectAccesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectsID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectsAcces", x => x.ProjectAccesID);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectsAccesProjectAccesID = table.Column<int>(nullable: true),
                    ProjectBugsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectsID);
                    table.ForeignKey(
                        name: "FK_Projects_ProjectBugs_ProjectBugsID",
                        column: x => x.ProjectBugsID,
                        principalTable: "ProjectBugs",
                        principalColumn: "ProjectBugsID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_ProjectsAcces_ProjectsAccesProjectAccesID",
                        column: x => x.ProjectsAccesProjectAccesID,
                        principalTable: "ProjectsAcces",
                        principalColumn: "ProjectAccesID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BugID = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    GeboorteDatum = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    allowEmailNotification = table.Column<bool>(nullable: true),
                    ProjectsAccesProjectAccesID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_User_ProjectsAcces_ProjectsAccesProjectAccesID",
                        column: x => x.ProjectsAccesProjectAccesID,
                        principalTable: "ProjectsAcces",
                        principalColumn: "ProjectAccesID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bugs",
                columns: table => new
                {
                    BugsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BugsPriorityID = table.Column<int>(nullable: false),
                    BugStatusID = table.Column<int>(nullable: false),
                    BugTitle = table.Column<string>(nullable: false),
                    BugDescription = table.Column<string>(nullable: false),
                    BugType = table.Column<string>(nullable: false),
                    BugCreatedByUserID = table.Column<int>(nullable: false),
                    BugCreatedOn = table.Column<DateTime>(nullable: false),
                    BugClosedByUserID = table.Column<int>(nullable: true),
                    BugClosedOn = table.Column<DateTime>(nullable: false),
                    ProjectBugsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bugs", x => x.BugsID);
                    table.ForeignKey(
                        name: "FK_Bugs_User_BugClosedByUserID",
                        column: x => x.BugClosedByUserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bugs_User_BugCreatedByUserID",
                        column: x => x.BugCreatedByUserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bugs_ProjectBugs_ProjectBugsID",
                        column: x => x.ProjectBugsID,
                        principalTable: "ProjectBugs",
                        principalColumn: "ProjectBugsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bugs_BugClosedByUserID",
                table: "Bugs",
                column: "BugClosedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Bugs_BugCreatedByUserID",
                table: "Bugs",
                column: "BugCreatedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Bugs_ProjectBugsID",
                table: "Bugs",
                column: "ProjectBugsID");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectBugsID",
                table: "Projects",
                column: "ProjectBugsID");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectsAccesProjectAccesID",
                table: "Projects",
                column: "ProjectsAccesProjectAccesID");

            migrationBuilder.CreateIndex(
                name: "IX_User_ProjectsAccesProjectAccesID",
                table: "User",
                column: "ProjectsAccesProjectAccesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bugs");

            migrationBuilder.DropTable(
                name: "BugsPriority");

            migrationBuilder.DropTable(
                name: "BugStatus");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "ProjectBugs");

            migrationBuilder.DropTable(
                name: "ProjectsAcces");
        }
    }
}
