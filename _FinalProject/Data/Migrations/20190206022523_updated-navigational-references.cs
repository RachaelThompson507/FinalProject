using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class updatednavigationalreferences : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UsersByRobins",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LetterId",
                table: "SubmissionStatuses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Robins",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Posts",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LetterId",
                table: "Posts",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Maps",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Letters",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LetterId",
                table: "Comments",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Calendars",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsersByRobins_RobinID",
                table: "UsersByRobins",
                column: "RobinID");

            migrationBuilder.CreateIndex(
                name: "IX_UsersByRobins_UserId",
                table: "UsersByRobins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubmissionStatuses_LetterId",
                table: "SubmissionStatuses",
                column: "LetterId");

            migrationBuilder.CreateIndex(
                name: "IX_Robins_UserId",
                table: "Robins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_LetterId",
                table: "Posts",
                column: "LetterId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_RobinId",
                table: "Posts",
                column: "RobinId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Maps_RobinId",
                table: "Maps",
                column: "RobinId");

            migrationBuilder.CreateIndex(
                name: "IX_Maps_UserId",
                table: "Maps",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Letters_RobinId",
                table: "Letters",
                column: "RobinId");

            migrationBuilder.CreateIndex(
                name: "IX_Letters_UserId",
                table: "Letters",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_LetterId",
                table: "Comments",
                column: "LetterId");

            migrationBuilder.CreateIndex(
                name: "IX_Calendars_RobinId",
                table: "Calendars",
                column: "RobinId");

            migrationBuilder.CreateIndex(
                name: "IX_Calendars_UserId",
                table: "Calendars",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Calendars_Robins_RobinId",
                table: "Calendars",
                column: "RobinId",
                principalTable: "Robins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Calendars_Users_UserId",
                table: "Calendars",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Letters_LetterId",
                table: "Comments",
                column: "LetterId",
                principalTable: "Letters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Letters_Robins_RobinId",
                table: "Letters",
                column: "RobinId",
                principalTable: "Robins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Letters_Users_UserId",
                table: "Letters",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Maps_Robins_RobinId",
                table: "Maps",
                column: "RobinId",
                principalTable: "Robins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Maps_Users_UserId",
                table: "Maps",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Letters_LetterId",
                table: "Posts",
                column: "LetterId",
                principalTable: "Letters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Robins_RobinId",
                table: "Posts",
                column: "RobinId",
                principalTable: "Robins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_UserId",
                table: "Posts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Robins_Users_UserId",
                table: "Robins",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubmissionStatuses_Letters_LetterId",
                table: "SubmissionStatuses",
                column: "LetterId",
                principalTable: "Letters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersByRobins_Robins_RobinID",
                table: "UsersByRobins",
                column: "RobinID",
                principalTable: "Robins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersByRobins_Users_UserId",
                table: "UsersByRobins",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calendars_Robins_RobinId",
                table: "Calendars");

            migrationBuilder.DropForeignKey(
                name: "FK_Calendars_Users_UserId",
                table: "Calendars");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Letters_LetterId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Letters_Robins_RobinId",
                table: "Letters");

            migrationBuilder.DropForeignKey(
                name: "FK_Letters_Users_UserId",
                table: "Letters");

            migrationBuilder.DropForeignKey(
                name: "FK_Maps_Robins_RobinId",
                table: "Maps");

            migrationBuilder.DropForeignKey(
                name: "FK_Maps_Users_UserId",
                table: "Maps");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Letters_LetterId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Robins_RobinId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_UserId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Robins_Users_UserId",
                table: "Robins");

            migrationBuilder.DropForeignKey(
                name: "FK_SubmissionStatuses_Letters_LetterId",
                table: "SubmissionStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersByRobins_Robins_RobinID",
                table: "UsersByRobins");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersByRobins_Users_UserId",
                table: "UsersByRobins");

            migrationBuilder.DropIndex(
                name: "IX_UsersByRobins_RobinID",
                table: "UsersByRobins");

            migrationBuilder.DropIndex(
                name: "IX_UsersByRobins_UserId",
                table: "UsersByRobins");

            migrationBuilder.DropIndex(
                name: "IX_SubmissionStatuses_LetterId",
                table: "SubmissionStatuses");

            migrationBuilder.DropIndex(
                name: "IX_Robins_UserId",
                table: "Robins");

            migrationBuilder.DropIndex(
                name: "IX_Posts_LetterId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_RobinId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_UserId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Maps_RobinId",
                table: "Maps");

            migrationBuilder.DropIndex(
                name: "IX_Maps_UserId",
                table: "Maps");

            migrationBuilder.DropIndex(
                name: "IX_Letters_RobinId",
                table: "Letters");

            migrationBuilder.DropIndex(
                name: "IX_Letters_UserId",
                table: "Letters");

            migrationBuilder.DropIndex(
                name: "IX_Comments_LetterId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Calendars_RobinId",
                table: "Calendars");

            migrationBuilder.DropIndex(
                name: "IX_Calendars_UserId",
                table: "Calendars");

            migrationBuilder.DropColumn(
                name: "LetterId",
                table: "SubmissionStatuses");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Robins");

            migrationBuilder.DropColumn(
                name: "LetterId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "LetterId",
                table: "Comments");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UsersByRobins",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Posts",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Maps",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Letters",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Calendars",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
