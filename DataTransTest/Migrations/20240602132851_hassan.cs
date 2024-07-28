using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataTransTest.Migrations
{
    public partial class hassan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "a9c4317f-ee90-41b6-a473-584cea4267fa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "29774573-f4c4-4e23-b089-bb496d6f50a6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e4c34fb-be7a-42d1-8d75-1e3a55a79eb3", "AQAAAAEAACcQAAAAEDYJBBwDyp5E/KSYRgYIWTbpwNx2nOPrSWnHmgJGAs/2V1etxiUWy5W/dlYLfKoU8Q==", "ad4674e1-db70-4042-a2a8-911e1d54c8b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44f1ec9d-3b87-4390-92a8-1343e17ccf9e", "AQAAAAEAACcQAAAAEJ7D0/fsTzKgtK857MNOut981JNyMz+MnHw7UGuDwNo6TMyeFeMOwr3PnFGec+mODA==", "dd72694b-8f74-4099-9a24-be310eef5363" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
