using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataTransTest.Migrations
{
    public partial class modifyPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d4c56df2-4142-4571-bcf3-eca63ae93773");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "142e997b-e68c-439b-bcee-cc20e41273a1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3e630ee-a0f2-4aec-9e24-dccf407bf592", "AQAAAAEAACcQAAAAEPFi5UGiDj3nyce+/EGsYfSMKRavdFw2Lah0tRb2vR2PWffXUdYGy1H1GIEh+NuDHA==", "79844460-faca-420c-abdf-5af9d7effe04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e69020a-23f5-4929-a5c2-52fec94044a2", "AQAAAAEAACcQAAAAEDhM4a+4/tq/4NY9QvKOOpldJW3V3WnVn/cQJxf7GvtPcRMwuce7hyTCqqeGUCy3AA==", "deb82ff7-6f29-47e9-8323-366dfad57c53" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "6382cf4a-6216-48ae-8c09-388657a81936");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "8e7bf013-1112-4e58-8255-5f879212d337");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e90e7109-feb6-4526-b880-50c0ea54b12d", "AQAAAAEAACcQAAAAEKfPl0g/h3eG4OnoqGdOYVSI9R2Sz3wgfEesC1sJ3ZMCduOb5B+ywWaeqi0F1HkWJA==", "801db4f4-98c0-42c6-884b-9f98449bcc74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "010ee2f4-d300-41e2-86ae-a20d63557f29", "AQAAAAEAACcQAAAAEN41YgrbZ3kGz8II0ghxL/6UvRiipfbwt3QRnjXleaZup19XZzesnTOgeyj72esEpw==", "3559a921-9003-4876-92e8-d3f4e38a8aea" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AppUserId", "Body", "Title" },
                values: new object[,]
                {
                    { 1, "", "sssssss", "Sport" },
                    { 2, "", "yyyyyyy", "Yemen" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "AppUserId", "Content", "PostId" },
                values: new object[] { 1, "", "ccccccc", 1 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "AppUserId", "Content", "PostId" },
                values: new object[] { 2, "", "ccccccc", 2 });
        }
    }
}
