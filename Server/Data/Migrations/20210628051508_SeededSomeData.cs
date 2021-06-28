using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededSomeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 6, 28, 14, 45, 8, 78, DateTimeKind.Local).AddTicks(6239), new DateTime(2021, 6, 28, 14, 45, 8, 80, DateTimeKind.Local).AddTicks(7441), "Black", "System" },
                    { 2, "System", new DateTime(2021, 6, 28, 14, 45, 8, 80, DateTimeKind.Local).AddTicks(8806), new DateTime(2021, 6, 28, 14, 45, 8, 80, DateTimeKind.Local).AddTicks(8819), "Black", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 6, 28, 14, 45, 8, 82, DateTimeKind.Local).AddTicks(1832), new DateTime(2021, 6, 28, 14, 45, 8, 82, DateTimeKind.Local).AddTicks(1845), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 6, 28, 14, 45, 8, 82, DateTimeKind.Local).AddTicks(1850), new DateTime(2021, 6, 28, 14, 45, 8, 82, DateTimeKind.Local).AddTicks(1851), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 6, 28, 14, 45, 8, 82, DateTimeKind.Local).AddTicks(5992), new DateTime(2021, 6, 28, 14, 45, 8, 82, DateTimeKind.Local).AddTicks(6006), "Celica", "System" },
                    { 2, "System", new DateTime(2021, 6, 28, 14, 45, 8, 82, DateTimeKind.Local).AddTicks(6010), new DateTime(2021, 6, 28, 14, 45, 8, 82, DateTimeKind.Local).AddTicks(6012), "Camry", "System" },
                    { 3, "System", new DateTime(2021, 6, 28, 14, 45, 8, 82, DateTimeKind.Local).AddTicks(6014), new DateTime(2021, 6, 28, 14, 45, 8, 82, DateTimeKind.Local).AddTicks(6015), "3 Series", "System" },
                    { 4, "System", new DateTime(2021, 6, 28, 14, 45, 8, 82, DateTimeKind.Local).AddTicks(6017), new DateTime(2021, 6, 28, 14, 45, 8, 82, DateTimeKind.Local).AddTicks(6018), "Z3", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
