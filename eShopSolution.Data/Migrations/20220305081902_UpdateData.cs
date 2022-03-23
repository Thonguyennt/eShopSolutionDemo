using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class UpdateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 5, 15, 19, 1, 927, DateTimeKind.Local).AddTicks(9344),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 24, 15, 9, 38, 327, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("3f7fd59c-80fd-4989-be8f-384fec9e9097"),
                column: "ConcurrencyStamp",
                value: "d699acf6-2080-449e-a378-34b372e58d3f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ad03a27-92ce-4e87-b04d-dec46029317e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cb5fd002-09c1-4bf1-8f60-dbde9b1633ab", "AQAAAAEAACcQAAAAEAtdLevLtvWPvF0qWYIBTmEMugSUBXNHorUlSvG8V6OYXf8cwR+YqWVaDo+o3a6Ikw==" });

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
                value: new DateTime(2022, 3, 5, 15, 19, 1, 945, DateTimeKind.Local).AddTicks(3614));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 24, 15, 9, 38, 327, DateTimeKind.Local).AddTicks(1838),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 3, 5, 15, 19, 1, 927, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("3f7fd59c-80fd-4989-be8f-384fec9e9097"),
                column: "ConcurrencyStamp",
                value: "5b452d4a-faf3-47b3-aabf-079dd41db9b0");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ad03a27-92ce-4e87-b04d-dec46029317e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "40bf9d92-d57f-406d-952b-fe44cf58afbf", "AQAAAAEAACcQAAAAEJoTr1oksZOhOXetwhU+D9f7EDW7tuli7iQgMTE0oEEQr4vCbKZQsQpbzqaugSUong==" });

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
                value: new DateTime(2022, 2, 24, 15, 9, 38, 351, DateTimeKind.Local).AddTicks(4293));
        }
    }
}
