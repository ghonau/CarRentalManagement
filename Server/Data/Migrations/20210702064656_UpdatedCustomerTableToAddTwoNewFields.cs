using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class UpdatedCustomerTableToAddTwoNewFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "321a9501-1fa3-4c68-86e4-776d7b9278b7",
                column: "ConcurrencyStamp",
                value: "f30c84ce-31ca-4e69-b6fb-3a174bde3765");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "321a9501-1fa3-4c68-86e4-776d7b9278b8",
                column: "ConcurrencyStamp",
                value: "32f1750f-e9f3-4d2c-982d-7cb515f2f6a7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7b94f54-b0c7-481a-9673-c053df841567",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bc0d77f-09ba-43a3-8d21-3a110c806282", "AQAAAAEAACcQAAAAEMjwmbwGtxYpUpSTMK0cXVBxCenZbnpv+TW4gkTv2C2v60IQFdaBhPA4c6PuHquamQ==", "5f00d60d-5993-4a3b-b036-abefe84c930c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7b94f54-b0c7-481a-9673-c053df841568",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f313107-1e18-4a0d-8ee0-bae14e4be91e", "AQAAAAEAACcQAAAAEFYzqTnyasu3cpKTLg/DcxvRTssmZ6LiOjkWHTrr+rR41MR0y3uovpBUMEage0Yuxg==", "2e537cfd-cede-4a9f-a282-69d357c27c72" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 16, 16, 55, 595, DateTimeKind.Local).AddTicks(1117), new DateTime(2021, 7, 2, 16, 16, 55, 597, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 16, 16, 55, 597, DateTimeKind.Local).AddTicks(3702), new DateTime(2021, 7, 2, 16, 16, 55, 597, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 16, 16, 55, 598, DateTimeKind.Local).AddTicks(3569), new DateTime(2021, 7, 2, 16, 16, 55, 598, DateTimeKind.Local).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 16, 16, 55, 598, DateTimeKind.Local).AddTicks(3588), new DateTime(2021, 7, 2, 16, 16, 55, 598, DateTimeKind.Local).AddTicks(3589) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 16, 16, 55, 598, DateTimeKind.Local).AddTicks(6559), new DateTime(2021, 7, 2, 16, 16, 55, 598, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 16, 16, 55, 598, DateTimeKind.Local).AddTicks(6573), new DateTime(2021, 7, 2, 16, 16, 55, 598, DateTimeKind.Local).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 16, 16, 55, 598, DateTimeKind.Local).AddTicks(6577), new DateTime(2021, 7, 2, 16, 16, 55, 598, DateTimeKind.Local).AddTicks(6578) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 16, 16, 55, 598, DateTimeKind.Local).AddTicks(6580), new DateTime(2021, 7, 2, 16, 16, 55, 598, DateTimeKind.Local).AddTicks(6581) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

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
    }
}
