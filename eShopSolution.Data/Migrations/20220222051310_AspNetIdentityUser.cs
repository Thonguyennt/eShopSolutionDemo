using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AspNetIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 22, 12, 13, 9, 545, DateTimeKind.Local).AddTicks(4562),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 22, 11, 53, 33, 903, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("3f7fd59c-80fd-4989-be8f-384fec9e9097"), "f246a0e4-07e9-4057-b9b9-5063faf3e09a", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("5ad03a27-92ce-4e87-b04d-dec46029317e"), new Guid("3f7fd59c-80fd-4989-be8f-384fec9e9097") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("5ad03a27-92ce-4e87-b04d-dec46029317e"), 0, "508d88d8-70fb-4a32-9f00-37cc4d8db1e3", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "tedu.international@gmail.com", true, "Toan", "Bach", false, null, "tedu.international@gmail.com", "admin", "AQAAAAEAACcQAAAAEIqXAPfO5xBQFW/43PPTKJ6y0JSflxvK95d1sKma8zJp7zVtl25nAClHHVvB8qNIug==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 12, 13, 9, 560, DateTimeKind.Local).AddTicks(7107));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("3f7fd59c-80fd-4989-be8f-384fec9e9097"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("5ad03a27-92ce-4e87-b04d-dec46029317e"), new Guid("3f7fd59c-80fd-4989-be8f-384fec9e9097") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ad03a27-92ce-4e87-b04d-dec46029317e"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 22, 11, 53, 33, 903, DateTimeKind.Local).AddTicks(9431),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 2, 22, 12, 13, 9, 545, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 11, 53, 33, 918, DateTimeKind.Local).AddTicks(2023));
        }
    }
}