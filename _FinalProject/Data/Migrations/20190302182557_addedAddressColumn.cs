using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class addedAddressColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3a75225c-1dd3-4609-a2f2-7e4095e7fb13", "2f731147-0fdf-4d7b-ab46-dda654881b7d", "GeneralUser", "GENERALUSER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "45931194-d531-467d-a349-fe2a13042ba4", "94c58648-3492-498f-b6dc-547a7ec6368d", "RobinAdmin", "ROBINADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8bec359f-777d-4d29-8901-1dfc855e5041", "3eca73e2-32fc-406a-8ca4-51c211e1428a", "SuperAdmin", "SUPERADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "3a75225c-1dd3-4609-a2f2-7e4095e7fb13", "2f731147-0fdf-4d7b-ab46-dda654881b7d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "45931194-d531-467d-a349-fe2a13042ba4", "94c58648-3492-498f-b6dc-547a7ec6368d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "8bec359f-777d-4d29-8901-1dfc855e5041", "3eca73e2-32fc-406a-8ca4-51c211e1428a" });

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

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
    }
}
