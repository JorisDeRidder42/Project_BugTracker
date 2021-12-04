using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class BugTrackerMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_User_BugClosedByUserID",
                table: "Bugs");

            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_User_BugCreatedByUserID",
                table: "Bugs");

            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_ProjectBugs_ProjectBugsID",
                table: "Bugs");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_ProjectBugs_ProjectBugsID",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_ProjectsAcces_ProjectsAccesProjectAccesID",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_User_ProjectsAcces_ProjectsAccesProjectAccesID",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_ProjectsAccesProjectAccesID",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ProjectBugsID",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ProjectsAccesProjectAccesID",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Bugs_BugClosedByUserID",
                table: "Bugs");

            migrationBuilder.DropIndex(
                name: "IX_Bugs_BugCreatedByUserID",
                table: "Bugs");

            migrationBuilder.DropIndex(
                name: "IX_Bugs_ProjectBugsID",
                table: "Bugs");

            migrationBuilder.DropColumn(
                name: "ProjectsAccesProjectAccesID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ProjectBugsID",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectsAccesProjectAccesID",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "BugClosedByUserID",
                table: "Bugs");

            migrationBuilder.DropColumn(
                name: "BugCreatedByUserID",
                table: "Bugs");

            migrationBuilder.DropColumn(
                name: "ProjectBugsID",
                table: "Bugs");

            migrationBuilder.EnsureSchema(
                name: "BugTracker");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "User",
                newSchema: "BugTracker");

            migrationBuilder.RenameTable(
                name: "ProjectsAcces",
                newName: "ProjectsAcces",
                newSchema: "BugTracker");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "Projects",
                newSchema: "BugTracker");

            migrationBuilder.RenameTable(
                name: "ProjectBugs",
                newName: "ProjectBugs",
                newSchema: "BugTracker");

            migrationBuilder.RenameTable(
                name: "BugStatus",
                newName: "BugStatus",
                newSchema: "BugTracker");

            migrationBuilder.RenameTable(
                name: "BugsPriority",
                newName: "BugsPriority",
                newSchema: "BugTracker");

            migrationBuilder.RenameTable(
                name: "Bugs",
                newName: "Bugs",
                newSchema: "BugTracker");

            migrationBuilder.RenameColumn(
                name: "allowEmailNotification",
                schema: "BugTracker",
                table: "User",
                newName: "AllowEmailNotification");

            migrationBuilder.RenameColumn(
                name: "BugsPriorityID",
                schema: "BugTracker",
                table: "Bugs",
                newName: "BugsPriorityId");

            migrationBuilder.AddColumn<int>(
                name: "BugsID",
                schema: "BugTracker",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BugsID",
                schema: "BugTracker",
                table: "BugsPriority",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BugClosedBy",
                schema: "BugTracker",
                table: "Bugs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BugCreatedBy",
                schema: "BugTracker",
                table: "Bugs",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_User_BugsID",
                schema: "BugTracker",
                table: "User",
                column: "BugsID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectsAcces_ProjectsID",
                schema: "BugTracker",
                table: "ProjectsAcces",
                column: "ProjectsID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectsAcces_UserID",
                schema: "BugTracker",
                table: "ProjectsAcces",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBugs_BugsID",
                schema: "BugTracker",
                table: "ProjectBugs",
                column: "BugsID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBugs_ProjectsID",
                schema: "BugTracker",
                table: "ProjectBugs",
                column: "ProjectsID");

            migrationBuilder.CreateIndex(
                name: "IX_BugsPriority_BugsID",
                schema: "BugTracker",
                table: "BugsPriority",
                column: "BugsID");

            migrationBuilder.CreateIndex(
                name: "IX_Bugs_BugStatusID",
                schema: "BugTracker",
                table: "Bugs",
                column: "BugStatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_BugStatus_BugStatusID",
                schema: "BugTracker",
                table: "Bugs",
                column: "BugStatusID",
                principalSchema: "BugTracker",
                principalTable: "BugStatus",
                principalColumn: "BugStatusID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BugsPriority_Bugs_BugsID",
                schema: "BugTracker",
                table: "BugsPriority",
                column: "BugsID",
                principalSchema: "BugTracker",
                principalTable: "Bugs",
                principalColumn: "BugsID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectBugs_Bugs_BugsID",
                schema: "BugTracker",
                table: "ProjectBugs",
                column: "BugsID",
                principalSchema: "BugTracker",
                principalTable: "Bugs",
                principalColumn: "BugsID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectBugs_Projects_ProjectsID",
                schema: "BugTracker",
                table: "ProjectBugs",
                column: "ProjectsID",
                principalSchema: "BugTracker",
                principalTable: "Projects",
                principalColumn: "ProjectsID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectsAcces_Projects_ProjectsID",
                schema: "BugTracker",
                table: "ProjectsAcces",
                column: "ProjectsID",
                principalSchema: "BugTracker",
                principalTable: "Projects",
                principalColumn: "ProjectsID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectsAcces_User_UserID",
                schema: "BugTracker",
                table: "ProjectsAcces",
                column: "UserID",
                principalSchema: "BugTracker",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Bugs_BugsID",
                schema: "BugTracker",
                table: "User",
                column: "BugsID",
                principalSchema: "BugTracker",
                principalTable: "Bugs",
                principalColumn: "BugsID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_BugStatus_BugStatusID",
                schema: "BugTracker",
                table: "Bugs");

            migrationBuilder.DropForeignKey(
                name: "FK_BugsPriority_Bugs_BugsID",
                schema: "BugTracker",
                table: "BugsPriority");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectBugs_Bugs_BugsID",
                schema: "BugTracker",
                table: "ProjectBugs");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectBugs_Projects_ProjectsID",
                schema: "BugTracker",
                table: "ProjectBugs");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectsAcces_Projects_ProjectsID",
                schema: "BugTracker",
                table: "ProjectsAcces");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectsAcces_User_UserID",
                schema: "BugTracker",
                table: "ProjectsAcces");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Bugs_BugsID",
                schema: "BugTracker",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_BugsID",
                schema: "BugTracker",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_ProjectsAcces_ProjectsID",
                schema: "BugTracker",
                table: "ProjectsAcces");

            migrationBuilder.DropIndex(
                name: "IX_ProjectsAcces_UserID",
                schema: "BugTracker",
                table: "ProjectsAcces");

            migrationBuilder.DropIndex(
                name: "IX_ProjectBugs_BugsID",
                schema: "BugTracker",
                table: "ProjectBugs");

            migrationBuilder.DropIndex(
                name: "IX_ProjectBugs_ProjectsID",
                schema: "BugTracker",
                table: "ProjectBugs");

            migrationBuilder.DropIndex(
                name: "IX_BugsPriority_BugsID",
                schema: "BugTracker",
                table: "BugsPriority");

            migrationBuilder.DropIndex(
                name: "IX_Bugs_BugStatusID",
                schema: "BugTracker",
                table: "Bugs");

            migrationBuilder.DropColumn(
                name: "BugsID",
                schema: "BugTracker",
                table: "User");

            migrationBuilder.DropColumn(
                name: "BugsID",
                schema: "BugTracker",
                table: "BugsPriority");

            migrationBuilder.DropColumn(
                name: "BugClosedBy",
                schema: "BugTracker",
                table: "Bugs");

            migrationBuilder.DropColumn(
                name: "BugCreatedBy",
                schema: "BugTracker",
                table: "Bugs");

            migrationBuilder.RenameTable(
                name: "User",
                schema: "BugTracker",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "ProjectsAcces",
                schema: "BugTracker",
                newName: "ProjectsAcces");

            migrationBuilder.RenameTable(
                name: "Projects",
                schema: "BugTracker",
                newName: "Projects");

            migrationBuilder.RenameTable(
                name: "ProjectBugs",
                schema: "BugTracker",
                newName: "ProjectBugs");

            migrationBuilder.RenameTable(
                name: "BugStatus",
                schema: "BugTracker",
                newName: "BugStatus");

            migrationBuilder.RenameTable(
                name: "BugsPriority",
                schema: "BugTracker",
                newName: "BugsPriority");

            migrationBuilder.RenameTable(
                name: "Bugs",
                schema: "BugTracker",
                newName: "Bugs");

            migrationBuilder.RenameColumn(
                name: "AllowEmailNotification",
                table: "User",
                newName: "allowEmailNotification");

            migrationBuilder.RenameColumn(
                name: "BugsPriorityId",
                table: "Bugs",
                newName: "BugsPriorityID");

            migrationBuilder.AddColumn<int>(
                name: "ProjectsAccesProjectAccesID",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectBugsID",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectsAccesProjectAccesID",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BugClosedByUserID",
                table: "Bugs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BugCreatedByUserID",
                table: "Bugs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProjectBugsID",
                table: "Bugs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_ProjectsAccesProjectAccesID",
                table: "User",
                column: "ProjectsAccesProjectAccesID");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectBugsID",
                table: "Projects",
                column: "ProjectBugsID");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectsAccesProjectAccesID",
                table: "Projects",
                column: "ProjectsAccesProjectAccesID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_User_BugClosedByUserID",
                table: "Bugs",
                column: "BugClosedByUserID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_User_BugCreatedByUserID",
                table: "Bugs",
                column: "BugCreatedByUserID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_ProjectBugs_ProjectBugsID",
                table: "Bugs",
                column: "ProjectBugsID",
                principalTable: "ProjectBugs",
                principalColumn: "ProjectBugsID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_ProjectBugs_ProjectBugsID",
                table: "Projects",
                column: "ProjectBugsID",
                principalTable: "ProjectBugs",
                principalColumn: "ProjectBugsID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_ProjectsAcces_ProjectsAccesProjectAccesID",
                table: "Projects",
                column: "ProjectsAccesProjectAccesID",
                principalTable: "ProjectsAcces",
                principalColumn: "ProjectAccesID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_ProjectsAcces_ProjectsAccesProjectAccesID",
                table: "User",
                column: "ProjectsAccesProjectAccesID",
                principalTable: "ProjectsAcces",
                principalColumn: "ProjectAccesID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
