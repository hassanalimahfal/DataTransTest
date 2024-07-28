using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataTransTest.Migrations
{
    public partial class mahfal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "8dbbbb42-96f2-4346-b169-c964b0744fb9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "bb441dc4-a3d3-4362-a472-15c9e960fdf7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e97da888-3714-4f20-bfaf-3a466c8d8239", "AQAAAAEAACcQAAAAEFoRCxRVqIXbf/X9Sr4DvpeDULNNCu3xhWc5f3J/VYwaXYyewwCfK/HYzwDV6vc/sQ==", "11c89c11-4fe7-45ea-8757-34854ae21498" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec702bd4-caec-4c5a-8323-698e1af1041e", "AQAAAAEAACcQAAAAECRUDceos+yKjxh8oPTlMEotUPGx5LLAeJQ1yujvcap/dRra89OJF+8OIvUIBf/A3Q==", "2647464d-ea68-4458-a8b1-7d2d96d09270" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "74e41341-172b-4c90-b845-78051d23ee19");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "2d69cd44-e921-44dc-8767-7fb307fe4449");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13f2ada7-3686-4fec-96ce-8717c19534c4", "AQAAAAEAACcQAAAAEOJRKgVSt5V5px8juZXFCfngAtY2ITWBeDJW+8997YpbszVV717gPgk6tuNOBrrRXQ==", "b04fff4b-796d-47f9-b355-41fc9032668e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e53a283-6b28-4cbb-9dac-7d3e2be7f1dc", "AQAAAAEAACcQAAAAELJqOhFGqLI3jikAr8L8j5lZO8WSQUkwzQS0JX/ZBHTCa2HPbMgQ3U9pnIlV96WDWw==", "cec6b226-9d63-4ed1-9084-d059d0239a81" });
        }
    }
}
