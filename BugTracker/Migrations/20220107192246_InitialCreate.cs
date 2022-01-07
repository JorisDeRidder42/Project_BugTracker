using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "BugTracker");

            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                schema: "BugTracker",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    ApplicationId = table.Column<int>(nullable: false),
                    BugsId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    Password = table.Column<string>(nullable: true),
                    GeboorteDatum = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    AllowEmailNotification = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                schema: "BugTracker",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BugsPriority",
                schema: "BugTracker",
                columns: table => new
                {
                    BugsPriorityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PriorityType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BugsPriority", x => x.BugsPriorityId);
                });

            migrationBuilder.CreateTable(
                name: "BugStatus",
                schema: "BugTracker",
                columns: table => new
                {
                    BugStatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BugStatusType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BugStatus", x => x.BugStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                schema: "BugTracker",
                columns: table => new
                {
                    ProjectsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    Status = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectsId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                schema: "BugTracker",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalSchema: "BugTracker",
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                schema: "BugTracker",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalSchema: "BugTracker",
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                schema: "BugTracker",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalSchema: "BugTracker",
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                schema: "BugTracker",
                columns: table => new
                {
                    TeamId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamNaam = table.Column<string>(nullable: true),
                    AantalPersonen = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamId);
                    table.ForeignKey(
                        name: "FK_Teams_ApplicationUser_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalSchema: "BugTracker",
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                schema: "BugTracker",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "BugTracker",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                schema: "BugTracker",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "BugTracker",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalSchema: "BugTracker",
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bugs",
                schema: "BugTracker",
                columns: table => new
                {
                    BugsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<int>(nullable: false),
                    BugsPriorityId = table.Column<int>(nullable: false),
                    BugStatusId = table.Column<int>(nullable: false),
                    BugTitle = table.Column<string>(maxLength: 100, nullable: false),
                    BugDescription = table.Column<string>(nullable: false),
                    BugCreatedBy = table.Column<string>(nullable: false),
                    BugCreatedOn = table.Column<DateTime>(nullable: false),
                    BugClosedBy = table.Column<string>(nullable: true),
                    BugClosedOn = table.Column<DateTime>(nullable: true),
                    ApplicationUserId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bugs", x => x.BugsId);
                    table.ForeignKey(
                        name: "FK_Bugs_ApplicationUser_ApplicationUserId1",
                        column: x => x.ApplicationUserId1,
                        principalSchema: "BugTracker",
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bugs_BugStatus_BugStatusId",
                        column: x => x.BugStatusId,
                        principalSchema: "BugTracker",
                        principalTable: "BugStatus",
                        principalColumn: "BugStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bugs_BugsPriority_BugsPriorityId",
                        column: x => x.BugsPriorityId,
                        principalSchema: "BugTracker",
                        principalTable: "BugsPriority",
                        principalColumn: "BugsPriorityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectsAcces",
                schema: "BugTracker",
                columns: table => new
                {
                    ProjectAccesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectsId = table.Column<int>(nullable: false),
                    ApplicationId = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectsAcces", x => x.ProjectAccesId);
                    table.ForeignKey(
                        name: "FK_ProjectsAcces_ApplicationUser_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalSchema: "BugTracker",
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectsAcces_Projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalSchema: "BugTracker",
                        principalTable: "Projects",
                        principalColumn: "ProjectsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamProject",
                schema: "BugTracker",
                columns: table => new
                {
                    TeamProjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false),
                    ProjectsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamProject", x => x.TeamProjectId);
                    table.ForeignKey(
                        name: "FK_TeamProject_Projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalSchema: "BugTracker",
                        principalTable: "Projects",
                        principalColumn: "ProjectsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamProject_Teams_TeamId",
                        column: x => x.TeamId,
                        principalSchema: "BugTracker",
                        principalTable: "Teams",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectBugs",
                schema: "BugTracker",
                columns: table => new
                {
                    ProjectBugsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectsId = table.Column<int>(nullable: false),
                    BugsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectBugs", x => x.ProjectBugsId);
                    table.ForeignKey(
                        name: "FK_ProjectBugs_Bugs_BugsId",
                        column: x => x.BugsId,
                        principalSchema: "BugTracker",
                        principalTable: "Bugs",
                        principalColumn: "BugsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectBugs_Projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalSchema: "BugTracker",
                        principalTable: "Projects",
                        principalColumn: "ProjectsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "BugTracker",
                table: "ApplicationUser",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "BugTracker",
                table: "ApplicationUser",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "BugTracker",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "BugTracker",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "BugTracker",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "BugTracker",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "BugTracker",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Bugs_ApplicationUserId1",
                schema: "BugTracker",
                table: "Bugs",
                column: "ApplicationUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Bugs_BugStatusId",
                schema: "BugTracker",
                table: "Bugs",
                column: "BugStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Bugs_BugsPriorityId",
                schema: "BugTracker",
                table: "Bugs",
                column: "BugsPriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBugs_BugsId",
                schema: "BugTracker",
                table: "ProjectBugs",
                column: "BugsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBugs_ProjectsId",
                schema: "BugTracker",
                table: "ProjectBugs",
                column: "ProjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectsAcces_ApplicationUserId",
                schema: "BugTracker",
                table: "ProjectsAcces",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectsAcces_ProjectsId",
                schema: "BugTracker",
                table: "ProjectsAcces",
                column: "ProjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamProject_ProjectsId",
                schema: "BugTracker",
                table: "TeamProject",
                column: "ProjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamProject_TeamId",
                schema: "BugTracker",
                table: "TeamProject",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ApplicationUserId",
                schema: "BugTracker",
                table: "Teams",
                column: "ApplicationUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims",
                schema: "BugTracker");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims",
                schema: "BugTracker");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins",
                schema: "BugTracker");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles",
                schema: "BugTracker");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens",
                schema: "BugTracker");

            migrationBuilder.DropTable(
                name: "ProjectBugs",
                schema: "BugTracker");

            migrationBuilder.DropTable(
                name: "ProjectsAcces",
                schema: "BugTracker");

            migrationBuilder.DropTable(
                name: "TeamProject",
                schema: "BugTracker");

            migrationBuilder.DropTable(
                name: "AspNetRoles",
                schema: "BugTracker");

            migrationBuilder.DropTable(
                name: "Bugs",
                schema: "BugTracker");

            migrationBuilder.DropTable(
                name: "Projects",
                schema: "BugTracker");

            migrationBuilder.DropTable(
                name: "Teams",
                schema: "BugTracker");

            migrationBuilder.DropTable(
                name: "BugStatus",
                schema: "BugTracker");

            migrationBuilder.DropTable(
                name: "BugsPriority",
                schema: "BugTracker");

            migrationBuilder.DropTable(
                name: "ApplicationUser",
                schema: "BugTracker");
        }
    }
}
