using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class updateImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 24, 15, 9, 38, 327, DateTimeKind.Local).AddTicks(1838),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 23, 7, 39, 26, 592, DateTimeKind.Local).AddTicks(7734));

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 23, 7, 39, 26, 592, DateTimeKind.Local).AddTicks(7734),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 2, 24, 15, 9, 38, 327, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("3f7fd59c-80fd-4989-be8f-384fec9e9097"),
                column: "ConcurrencyStamp",
                value: "9d4b624f-de5f-477e-be23-7655b2527b92");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ad03a27-92ce-4e87-b04d-dec46029317e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d23674b8-4e82-4e22-8f15-fa8935e621ba", "AQAAAAEAACcQAAAAEKL3fIbg8v2jFJL5RBlS12SbMSRltyLL3InVznXAgJcM4Fk+HCELjBbVw/gIFeN5gA==" });

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
                value: new DateTime(2022, 2, 23, 7, 39, 26, 608, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }
    }
}