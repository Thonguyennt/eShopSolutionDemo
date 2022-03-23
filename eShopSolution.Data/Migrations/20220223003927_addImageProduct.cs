using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class addImageProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 23, 7, 39, 26, 592, DateTimeKind.Local).AddTicks(7734),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 22, 12, 13, 9, 545, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 22, 12, 13, 9, 545, DateTimeKind.Local).AddTicks(4562),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 2, 23, 7, 39, 26, 592, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("3f7fd59c-80fd-4989-be8f-384fec9e9097"),
                column: "ConcurrencyStamp",
                value: "f246a0e4-07e9-4057-b9b9-5063faf3e09a");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("5ad03a27-92ce-4e87-b04d-dec46029317e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "508d88d8-70fb-4a32-9f00-37cc4d8db1e3", "AQAAAAEAACcQAAAAEIqXAPfO5xBQFW/43PPTKJ6y0JSflxvK95d1sKma8zJp7zVtl25nAClHHVvB8qNIug==" });

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
    }
}