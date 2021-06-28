using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededRoleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "321a9501-1fa3-4c68-86e4-776d7b9278b7", "758cd9e4-d204-468d-a844-16386bc444a6", "User", "USER" },
                    { "321a9501-1fa3-4c68-86e4-776d7b9278b8", "397366c2-e3c3-425f-85f1-5be034a79fe0", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 28, 14, 52, 51, 863, DateTimeKind.Local).AddTicks(3686), new DateTime(2021, 6, 28, 14, 52, 51, 866, DateTimeKind.Local).AddTicks(2836) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 28, 14, 52, 51, 866, DateTimeKind.Local).AddTicks(4368), new DateTime(2021, 6, 28, 14, 52, 51, 866, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 28, 14, 52, 51, 867, DateTimeKind.Local).AddTicks(6792), new DateTime(2021, 6, 28, 14, 52, 51, 867, DateTimeKind.Local).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 28, 14, 52, 51, 867, DateTimeKind.Local).AddTicks(6811), new DateTime(2021, 6, 28, 14, 52, 51, 867, DateTimeKind.Local).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 28, 14, 52, 51, 868, DateTimeKind.Local).AddTicks(766), new DateTime(2021, 6, 28, 14, 52, 51, 868, DateTimeKind.Local).AddTicks(779) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 28, 14, 52, 51, 868, DateTimeKind.Local).AddTicks(784), new DateTime(2021, 6, 28, 14, 52, 51, 868, DateTimeKind.Local).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 28, 14, 52, 51, 868, DateTimeKind.Local).AddTicks(788), new DateTime(2021, 6, 28, 14, 52, 51, 868, DateTimeKind.Local).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 28, 14, 52, 51, 868, DateTimeKind.Local).AddTicks(792), new DateTime(2021, 6, 28, 14, 52, 51, 868, DateTimeKind.Local).AddTicks(794) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "321a9501-1fa3-4c68-86e4-776d7b9278b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "321a9501-1fa3-4c68-86e4-776d7b9278b8");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 28, 14, 45, 8, 78, DateTimeKind.Local).AddTicks(6239), new DateTime(2021, 6, 28, 14, 45, 8, 80, DateTimeKind.Local).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 28, 14, 45, 8, 80, DateTimeKind.Local).AddTicks(8806), new DateTime(2021, 6, 28, 14, 45, 8, 80, DateTimeKind.Local).AddTicks(8819) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 28, 14, 45, 8, 82, DateTimeKind.Local).AddTicks(1832), new DateTime(2021, 6, 28, 14, 45, 8, 82, DateTimeKind.Local).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 28, 14, 45, 8, 82, DateTimeKind.Local).AddTicks(1850), new DateTime(2021, 6, 28, 14, 45, 8, 82, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 28, 14, 45, 8, 82, DateTimeKind.Local).AddTicks(5992), new DateTime(2021, 6, 28, 14, 45, 8, 82, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 28, 14, 45, 8, 82, DateTimeKind.Local).AddTicks(6010), new DateTime(2021, 6, 28, 14, 45, 8, 82, DateTimeKind.Local).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 28, 14, 45, 8, 82, DateTimeKind.Local).AddTicks(6014), new DateTime(2021, 6, 28, 14, 45, 8, 82, DateTimeKind.Local).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 28, 14, 45, 8, 82, DateTimeKind.Local).AddTicks(6017), new DateTime(2021, 6, 28, 14, 45, 8, 82, DateTimeKind.Local).AddTicks(6018) });
        }
    }
}
