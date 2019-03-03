using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class addedModelEVENTCS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "223d4071-73b5-42d3-b76b-9302887e3b79", "0120078d-cd47-4b77-a494-2dd0bbc9a7bc" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "61f14167-ef95-4389-987e-270b513e5b23", "fca5905e-abcb-43c5-9ff1-447f6f2e4883" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "a4035352-12e4-4b10-a6ce-bd5cf8fdeadc", "0ad977da-e489-4816-9d65-d6cead6e6a10" });

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Zip",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    EventDate = table.Column<DateTime>(nullable: false),
                    Attending = table.Column<bool>(nullable: false),
                    EventComment = table.Column<string>(nullable: true),
                    RobinId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    CalendarId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Robins_RobinId",
                        column: x => x.RobinId,
                        principalTable: "Robins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Events_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1f617d3b-e6b2-4b23-bcf2-1cfe0a36b525", "f0c1e617-5f12-41a8-a596-595ed09fdf1f", "GeneralUser", "GENERALUSER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a141e5a2-21fc-4a42-917b-6d4a437602a4", "5b12cc91-7e15-4b8e-827a-2214d5b166ab", "RobinAdmin", "ROBINADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "276e1993-f5d2-41e0-8eb8-3bd8b849b1e6", "f4dd2bc5-c99f-4f33-af56-b741753480bf", "SuperAdmin", "SUPERADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_Events_RobinId",
                table: "Events",
                column: "RobinId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserId",
                table: "Events",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "1f617d3b-e6b2-4b23-bcf2-1cfe0a36b525", "f0c1e617-5f12-41a8-a596-595ed09fdf1f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "276e1993-f5d2-41e0-8eb8-3bd8b849b1e6", "f4dd2bc5-c99f-4f33-af56-b741753480bf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "a141e5a2-21fc-4a42-917b-6d4a437602a4", "5b12cc91-7e15-4b8e-827a-2214d5b166ab" });

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "State",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Zip",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a4035352-12e4-4b10-a6ce-bd5cf8fdeadc", "0ad977da-e489-4816-9d65-d6cead6e6a10", "GeneralUser", "GENERALUSER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "223d4071-73b5-42d3-b76b-9302887e3b79", "0120078d-cd47-4b77-a494-2dd0bbc9a7bc", "RobinAdmin", "ROBINADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "61f14167-ef95-4389-987e-270b513e5b23", "fca5905e-abcb-43c5-9ff1-447f6f2e4883", "SuperAdmin", "SUPERADMIN" });
        }
    }
}
