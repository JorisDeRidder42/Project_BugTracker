using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_User_UserId",
                schema: "BugTracker",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_User_UserId",
                schema: "BugTracker",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_User_UserId",
                schema: "BugTracker",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_User_UserId",
                schema: "BugTracker",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_User_ApplicationUserId",
                schema: "BugTracker",
                table: "Bugs");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectsAcces_User_ApplicationUserId",
                schema: "BugTracker",
                table: "ProjectsAcces");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_User_ApplicationUserId",
                schema: "BugTracker",
                table: "Teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                schema: "BugTracker",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                schema: "BugTracker",
                newName: "ApplicationUser",
                newSchema: "BugTracker");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationId",
                schema: "BugTracker",
                table: "Bugs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUser",
                schema: "BugTracker",
                table: "ApplicationUser",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_ApplicationUser_UserId",
                schema: "BugTracker",
                table: "AspNetUserClaims",
                column: "UserId",
                principalSchema: "BugTracker",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_ApplicationUser_UserId",
                schema: "BugTracker",
                table: "AspNetUserLogins",
                column: "UserId",
                principalSchema: "BugTracker",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_ApplicationUser_UserId",
                schema: "BugTracker",
                table: "AspNetUserRoles",
                column: "UserId",
                principalSchema: "BugTracker",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_ApplicationUser_UserId",
                schema: "BugTracker",
                table: "AspNetUserTokens",
                column: "UserId",
                principalSchema: "BugTracker",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_ApplicationUser_ApplicationUserId",
                schema: "BugTracker",
                table: "Bugs",
                column: "ApplicationUserId",
                principalSchema: "BugTracker",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectsAcces_ApplicationUser_ApplicationUserId",
                schema: "BugTracker",
                table: "ProjectsAcces",
                column: "ApplicationUserId",
                principalSchema: "BugTracker",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_ApplicationUser_UserId",
                schema: "BugTracker",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_ApplicationUser_UserId",
                schema: "BugTracker",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_ApplicationUser_UserId",
                schema: "BugTracker",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_ApplicationUser_UserId",
                schema: "BugTracker",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_ApplicationUser_ApplicationUserId",
                schema: "BugTracker",
                table: "Bugs");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectsAcces_ApplicationUser_ApplicationUserId",
                schema: "BugTracker",
                table: "ProjectsAcces");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_ApplicationUser_ApplicationUserId",
                schema: "BugTracker",
                table: "Teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUser",
                schema: "BugTracker",
                table: "ApplicationUser");

            migrationBuilder.DropColumn(
                name: "ApplicationId",
                schema: "BugTracker",
                table: "Bugs");

            migrationBuilder.RenameTable(
                name: "ApplicationUser",
                schema: "BugTracker",
                newName: "User",
                newSchema: "BugTracker");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                schema: "BugTracker",
                table: "User",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_User_UserId",
                schema: "BugTracker",
                table: "AspNetUserClaims",
                column: "UserId",
                principalSchema: "BugTracker",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_User_UserId",
                schema: "BugTracker",
                table: "AspNetUserLogins",
                column: "UserId",
                principalSchema: "BugTracker",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_User_UserId",
                schema: "BugTracker",
                table: "AspNetUserRoles",
                column: "UserId",
                principalSchema: "BugTracker",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_User_UserId",
                schema: "BugTracker",
                table: "AspNetUserTokens",
                column: "UserId",
                principalSchema: "BugTracker",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_User_ApplicationUserId",
                schema: "BugTracker",
                table: "Bugs",
                column: "ApplicationUserId",
                principalSchema: "BugTracker",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectsAcces_User_ApplicationUserId",
                schema: "BugTracker",
                table: "ProjectsAcces",
                column: "ApplicationUserId",
                principalSchema: "BugTracker",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_User_ApplicationUserId",
                schema: "BugTracker",
                table: "Teams",
                column: "ApplicationUserId",
                principalSchema: "BugTracker",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
