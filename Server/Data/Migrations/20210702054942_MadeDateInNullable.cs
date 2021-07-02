using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class MadeDateInNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "321a9501-1fa3-4c68-86e4-776d7b9278b7",
                column: "ConcurrencyStamp",
                value: "beb87c94-d102-44df-8375-2443ce2d0ee6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "321a9501-1fa3-4c68-86e4-776d7b9278b8",
                column: "ConcurrencyStamp",
                value: "65869156-f87f-45f3-b349-608cbaa3b33e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7b94f54-b0c7-481a-9673-c053df841567",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ae61020-caaf-46e8-97ad-3577b4303811", "AQAAAAEAACcQAAAAEPVO3NHsO0+MJ224KGWtUjM0ViJsKDu9AgIW+0EqYYNDtQzRykNsaOt4I8j4UVX+qg==", "3927aa76-9de3-492b-be70-27e38bc3f24d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7b94f54-b0c7-481a-9673-c053df841568",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8c97526-c1d0-48e1-b472-f3567b88d9f8", "AQAAAAEAACcQAAAAEJN9eDLCDzJagIqMn65xsxwTypg7Mxr6LHZbKwBdTIsvdP162xKJLweILa5bXz2s9g==", "cf610135-3952-4b18-8512-c1e8f979f513" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 15, 19, 42, 66, DateTimeKind.Local).AddTicks(437), new DateTime(2021, 7, 2, 15, 19, 42, 68, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 15, 19, 42, 68, DateTimeKind.Local).AddTicks(3223), new DateTime(2021, 7, 2, 15, 19, 42, 68, DateTimeKind.Local).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 15, 19, 42, 69, DateTimeKind.Local).AddTicks(2964), new DateTime(2021, 7, 2, 15, 19, 42, 69, DateTimeKind.Local).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 15, 19, 42, 69, DateTimeKind.Local).AddTicks(2985), new DateTime(2021, 7, 2, 15, 19, 42, 69, DateTimeKind.Local).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 15, 19, 42, 69, DateTimeKind.Local).AddTicks(5990), new DateTime(2021, 7, 2, 15, 19, 42, 69, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 15, 19, 42, 69, DateTimeKind.Local).AddTicks(6009), new DateTime(2021, 7, 2, 15, 19, 42, 69, DateTimeKind.Local).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 15, 19, 42, 69, DateTimeKind.Local).AddTicks(6013), new DateTime(2021, 7, 2, 15, 19, 42, 69, DateTimeKind.Local).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 15, 19, 42, 69, DateTimeKind.Local).AddTicks(6016), new DateTime(2021, 7, 2, 15, 19, 42, 69, DateTimeKind.Local).AddTicks(6017) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "321a9501-1fa3-4c68-86e4-776d7b9278b7",
                column: "ConcurrencyStamp",
                value: "79027ba6-cb4f-4980-be60-be31c91d0387");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "321a9501-1fa3-4c68-86e4-776d7b9278b8",
                column: "ConcurrencyStamp",
                value: "19b70195-06d5-4ad4-af46-b479b4868030");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7b94f54-b0c7-481a-9673-c053df841567",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74ad0246-c099-4609-a726-e71a210ac395", "AQAAAAEAACcQAAAAEGBIi0Muqp+y3R2yuX++4MVNamO3mODICxKknVQKPA+etsdLJ8aVgiCwPzJIT+prOA==", "d6290053-e70b-4f95-8f8d-aaf79c0e0a1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7b94f54-b0c7-481a-9673-c053df841568",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "477d24c3-cbc7-46e5-a581-c2d65190bca6", "AQAAAAEAACcQAAAAEJOH/akG7demDMctTypHtHSsofpBn9suL1f+i0lRnQDsOpbU4U86DV8gv6Mfyf1QCw==", "404040bf-9155-46ce-9abb-a93f71929c4a" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 28, 15, 31, 21, 38, DateTimeKind.Local).AddTicks(3309), new DateTime(2021, 6, 28, 15, 31, 21, 40, DateTimeKind.Local).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 28, 15, 31, 21, 40, DateTimeKind.Local).AddTicks(7278), new DateTime(2021, 6, 28, 15, 31, 21, 40, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 28, 15, 31, 21, 42, DateTimeKind.Local).AddTicks(296), new DateTime(2021, 6, 28, 15, 31, 21, 42, DateTimeKind.Local).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 28, 15, 31, 21, 42, DateTimeKind.Local).AddTicks(315), new DateTime(2021, 6, 28, 15, 31, 21, 42, DateTimeKind.Local).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 28, 15, 31, 21, 42, DateTimeKind.Local).AddTicks(4194), new DateTime(2021, 6, 28, 15, 31, 21, 42, DateTimeKind.Local).AddTicks(4206) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 28, 15, 31, 21, 42, DateTimeKind.Local).AddTicks(4211), new DateTime(2021, 6, 28, 15, 31, 21, 42, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 28, 15, 31, 21, 42, DateTimeKind.Local).AddTicks(4215), new DateTime(2021, 6, 28, 15, 31, 21, 42, DateTimeKind.Local).AddTicks(4216) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 28, 15, 31, 21, 42, DateTimeKind.Local).AddTicks(4218), new DateTime(2021, 6, 28, 15, 31, 21, 42, DateTimeKind.Local).AddTicks(4219) });
        }
    }
}
