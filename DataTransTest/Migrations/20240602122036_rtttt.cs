using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataTransTest.Migrations
{
    public partial class rtttt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "4b2fcc3b-ec50-4b7d-a314-8bc639fdcc1f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "5e146808-0b7e-4afe-9b04-0997154caff9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "628e5e68-3660-4d2c-94ed-cb0db990d754", "AQAAAAEAACcQAAAAEKUenKU5QBrXODrGd96f0IoYHueT/GpjJIb2na9/NNufGlKLdqxeHFR5jBPYgh8sLA==", "7ee6826f-6f58-4a6f-a7ec-6b362a301bf1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8095bd9-fdb5-4329-8d54-885383bbdff2", "AQAAAAEAACcQAAAAEC7RDIGNALBIJGsv/N/l069vhMeSWb+Zh/OtH0ZZALIjNmmeg9/pZBnvnh/+Mt/d5Q==", "3f74fefb-6bc0-453a-8f5d-f1f142c9a7bb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
