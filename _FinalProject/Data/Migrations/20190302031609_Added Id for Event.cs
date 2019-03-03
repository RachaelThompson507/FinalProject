using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddedIdforEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "CalendarId",
                table: "Events",
                newName: "eventId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "66ccd4ec-e6ca-4c9f-86e4-24f08a7f3c62", "1ef3ff21-1ed0-4672-99d5-609e00b1e094", "GeneralUser", "GENERALUSER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "989f9d1a-cd0c-45e8-9c69-98366bf68de2", "4d59f3ef-91d6-4d02-9774-6b3b45809636", "RobinAdmin", "ROBINADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5f41c5c6-d7af-4317-8884-1b340bc8d73e", "cc00506d-6ce0-4552-8b48-c4ca4c0bf315", "SuperAdmin", "SUPERADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "5f41c5c6-d7af-4317-8884-1b340bc8d73e", "cc00506d-6ce0-4552-8b48-c4ca4c0bf315" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "66ccd4ec-e6ca-4c9f-86e4-24f08a7f3c62", "1ef3ff21-1ed0-4672-99d5-609e00b1e094" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "989f9d1a-cd0c-45e8-9c69-98366bf68de2", "4d59f3ef-91d6-4d02-9774-6b3b45809636" });

            migrationBuilder.RenameColumn(
                name: "eventId",
                table: "Events",
                newName: "CalendarId");

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
        }
    }
}
