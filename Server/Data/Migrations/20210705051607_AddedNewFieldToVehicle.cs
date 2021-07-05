using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedNewFieldToVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
