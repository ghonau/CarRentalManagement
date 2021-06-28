using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class UserAndUserRoleSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c7b94f54-b0c7-481a-9673-c053df841567", 0, "74ad0246-c099-4609-a726-e71a210ac395", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEGBIi0Muqp+y3R2yuX++4MVNamO3mODICxKknVQKPA+etsdLJ8aVgiCwPzJIT+prOA==", null, false, "d6290053-e70b-4f95-8f8d-aaf79c0e0a1f", false, "admin@localhost.com" },
                    { "c7b94f54-b0c7-481a-9673-c053df841568", 0, "477d24c3-cbc7-46e5-a581-c2d65190bca6", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEJOH/akG7demDMctTypHtHSsofpBn9suL1f+i0lRnQDsOpbU4U86DV8gv6Mfyf1QCw==", null, false, "404040bf-9155-46ce-9abb-a93f71929c4a", false, "user@localhost.com" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "321a9501-1fa3-4c68-86e4-776d7b9278b8", "c7b94f54-b0c7-481a-9673-c053df841567" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "321a9501-1fa3-4c68-86e4-776d7b9278b7", "c7b94f54-b0c7-481a-9673-c053df841568" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "321a9501-1fa3-4c68-86e4-776d7b9278b8", "c7b94f54-b0c7-481a-9673-c053df841567" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "321a9501-1fa3-4c68-86e4-776d7b9278b7", "c7b94f54-b0c7-481a-9673-c053df841568" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7b94f54-b0c7-481a-9673-c053df841567");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7b94f54-b0c7-481a-9673-c053df841568");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "321a9501-1fa3-4c68-86e4-776d7b9278b7",
                column: "ConcurrencyStamp",
                value: "758cd9e4-d204-468d-a844-16386bc444a6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "321a9501-1fa3-4c68-86e4-776d7b9278b8",
                column: "ConcurrencyStamp",
                value: "397366c2-e3c3-425f-85f1-5be034a79fe0");

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
    }
}
