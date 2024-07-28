using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataTransTest.Migrations
{
    public partial class dfrewsd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c84e30c1-8bb3-4de8-b391-589c5208efb5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "cb677803-e5a0-43db-8b91-a041d7fd11c2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff3fe20f-6774-4196-9b3a-3a6d487575d0", "AQAAAAEAACcQAAAAEAK0u31+R7BDEW67g+XjKu+Z1LS+jPt89+KvWfNxdFw348y2gFkHc1enNI6U8QWSEQ==", "ed7e0d07-22df-4abc-9b8f-a1de251eb514" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66f32cac-e80a-4d06-88ac-07d378154fd0", "AQAAAAEAACcQAAAAECeWi3AhJi4hMUprJOLzLCrNPoBPE2AM8y8GaigaQcSUvjweOsj90tpvx5JS9lqYlw==", "7dd2a7e7-f630-45ef-901d-3b76a7e0d14a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
