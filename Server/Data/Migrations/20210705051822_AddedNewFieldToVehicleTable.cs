using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedNewFieldToVehicleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "321a9501-1fa3-4c68-86e4-776d7b9278b7",
                column: "ConcurrencyStamp",
                value: "53a0abb6-647f-4c75-8fd7-9dd68be20a5e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "321a9501-1fa3-4c68-86e4-776d7b9278b8",
                column: "ConcurrencyStamp",
                value: "fd36978b-dc00-44ed-8174-11afe0f12689");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7b94f54-b0c7-481a-9673-c053df841567",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fbf8411-5c22-491d-81a3-dff4c7a671b3", "AQAAAAEAACcQAAAAEN5iov7ojcxkecw/AunBqtAPQRN4VgfWnHQdmRT6mBLQGM1WOxyy48FLYyVLOMedYQ==", "41d4522e-8c18-4681-ad5e-2bf1769ce2c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7b94f54-b0c7-481a-9673-c053df841568",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f50f7b3-ed74-42c3-9fb8-1b7c71264599", "AQAAAAEAACcQAAAAEGpbjjmhWj2rYFP1o2ieH6ibpCacvj+g6t7ekeq62MvDkCExNciACh/mM1Bk/Qf2xw==", "c6a86c8e-8980-4c87-80d5-c9d6fbc11407" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 48, 22, 167, DateTimeKind.Local).AddTicks(5251), new DateTime(2021, 7, 5, 14, 48, 22, 169, DateTimeKind.Local).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 48, 22, 170, DateTimeKind.Local).AddTicks(270), new DateTime(2021, 7, 5, 14, 48, 22, 170, DateTimeKind.Local).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 48, 22, 171, DateTimeKind.Local).AddTicks(1684), new DateTime(2021, 7, 5, 14, 48, 22, 171, DateTimeKind.Local).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 48, 22, 171, DateTimeKind.Local).AddTicks(1705), new DateTime(2021, 7, 5, 14, 48, 22, 171, DateTimeKind.Local).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 48, 22, 171, DateTimeKind.Local).AddTicks(4494), new DateTime(2021, 7, 5, 14, 48, 22, 171, DateTimeKind.Local).AddTicks(4503) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 48, 22, 171, DateTimeKind.Local).AddTicks(4506), new DateTime(2021, 7, 5, 14, 48, 22, 171, DateTimeKind.Local).AddTicks(4508) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 48, 22, 171, DateTimeKind.Local).AddTicks(4509), new DateTime(2021, 7, 5, 14, 48, 22, 171, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 48, 22, 171, DateTimeKind.Local).AddTicks(4512), new DateTime(2021, 7, 5, 14, 48, 22, 171, DateTimeKind.Local).AddTicks(4514) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Vehicles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "321a9501-1fa3-4c68-86e4-776d7b9278b7",
                column: "ConcurrencyStamp",
                value: "9696fc6e-e570-4195-a863-fd54cc493f32");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "321a9501-1fa3-4c68-86e4-776d7b9278b8",
                column: "ConcurrencyStamp",
                value: "4ebeed8c-334b-4642-b549-3d48476530a8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7b94f54-b0c7-481a-9673-c053df841567",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "feff9e65-854f-4874-b08b-54912f9c9e3b", "AQAAAAEAACcQAAAAEE1vA5tI7Exx3ZgfkQFInmo5upsnINtxWlXHisG3Vj3RaAw+DszANK0z/GeokrB+9g==", "687315b0-d569-430a-8200-7e87a1c31a2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7b94f54-b0c7-481a-9673-c053df841568",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b99858a9-2fd6-43b4-8e14-5c774e6f2cd2", "AQAAAAEAACcQAAAAENOQhaKkRsvOjpJpm51Oa9Jie2+RrEvVVu6Zi9S/cDc9fp3Na0Dh0aAF1inJW8nWGg==", "ac6c28bc-4eae-453d-84b0-6cc14e087921" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 46, 6, 674, DateTimeKind.Local).AddTicks(5803), new DateTime(2021, 7, 5, 14, 46, 6, 676, DateTimeKind.Local).AddTicks(7461) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 46, 6, 676, DateTimeKind.Local).AddTicks(8141), new DateTime(2021, 7, 5, 14, 46, 6, 676, DateTimeKind.Local).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 46, 6, 677, DateTimeKind.Local).AddTicks(8606), new DateTime(2021, 7, 5, 14, 46, 6, 677, DateTimeKind.Local).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 46, 6, 677, DateTimeKind.Local).AddTicks(8629), new DateTime(2021, 7, 5, 14, 46, 6, 677, DateTimeKind.Local).AddTicks(8631) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 46, 6, 678, DateTimeKind.Local).AddTicks(1495), new DateTime(2021, 7, 5, 14, 46, 6, 678, DateTimeKind.Local).AddTicks(1507) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 46, 6, 678, DateTimeKind.Local).AddTicks(1510), new DateTime(2021, 7, 5, 14, 46, 6, 678, DateTimeKind.Local).AddTicks(1512) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 46, 6, 678, DateTimeKind.Local).AddTicks(1514), new DateTime(2021, 7, 5, 14, 46, 6, 678, DateTimeKind.Local).AddTicks(1515) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 5, 14, 46, 6, 678, DateTimeKind.Local).AddTicks(1517), new DateTime(2021, 7, 5, 14, 46, 6, 678, DateTimeKind.Local).AddTicks(1518) });
        }
    }
}
