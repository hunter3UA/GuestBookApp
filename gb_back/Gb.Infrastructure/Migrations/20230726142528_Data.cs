using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Gb.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Comments",
                type: "nvarchar(max)",
                maxLength: 5000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Name", "Text" },
                values: new object[,]
                {
                    { new Guid("0319f450-5166-4e60-93b7-4bd563acfdca"), "John12", "Niccccccccccccccccceeeeeeeeeeeee" },
                    { new Guid("14b78268-d5c8-4fef-8f9d-0d2af152ecbe"), "John9", "Niccccccccccccccccceeeeeeeeeeeee" },
                    { new Guid("1f7a3a59-51d7-47e8-bcb4-0dcb817516a7"), "John2", "Niccccccccccccccccceeeeeeeeeeeee" },
                    { new Guid("2cb6e5a7-1653-4df4-baae-c6405436aeb9"), "John4", "Niccccccccccccccccceeeeeeeeeeeee" },
                    { new Guid("569a832f-8e25-4eb0-be89-29d841c8b4ba"), "John3", "Niccccccccccccccccceeeeeeeeeeeee" },
                    { new Guid("66348dfd-cf4f-46e4-a2d9-edce86838289"), "John13", "Niccccccccccccccccceeeeeeeeeeeee" },
                    { new Guid("84280c21-49a1-4f44-a6ef-e6bdfea9b0ab"), "John6", "Niccccccccccccccccceeeeeeeeeeeee" },
                    { new Guid("87f7a435-53e1-4fd1-9eef-be987b721ec8"), "John1", "Niccccccccccccccccceeeeeeeeeeeee" },
                    { new Guid("93ffef0a-5bca-4f8c-a064-9b5b6645d243"), "John8", "Niccccccccccccccccceeeeeeeeeeeee" },
                    { new Guid("948f7b11-58f6-4fd8-8423-56ddaafe5b19"), "John15", "Niccccccccccccccccceeeeeeeeeeeee" },
                    { new Guid("a40caa46-f378-4b7e-b1fa-6ed9e90464fb"), "John5", "Niccccccccccccccccceeeeeeeeeeeee" },
                    { new Guid("af6519d8-2163-46a6-b5ab-01706d1dc6f6"), "John10", "Niccccccccccccccccceeeeeeeeeeeee" },
                    { new Guid("b4f4e2ae-7032-42fa-882c-47d8dece6532"), "John7", "Niccccccccccccccccceeeeeeeeeeeee" },
                    { new Guid("cb48c089-f391-4913-a255-914d179e0be5"), "John14", "Niccccccccccccccccceeeeeeeeeeeee" },
                    { new Guid("dbed867a-a607-4dd4-93aa-c71e4619e556"), "John11", "Niccccccccccccccccceeeeeeeeeeeee" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("0319f450-5166-4e60-93b7-4bd563acfdca"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("14b78268-d5c8-4fef-8f9d-0d2af152ecbe"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("1f7a3a59-51d7-47e8-bcb4-0dcb817516a7"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("2cb6e5a7-1653-4df4-baae-c6405436aeb9"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("569a832f-8e25-4eb0-be89-29d841c8b4ba"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("66348dfd-cf4f-46e4-a2d9-edce86838289"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("84280c21-49a1-4f44-a6ef-e6bdfea9b0ab"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("87f7a435-53e1-4fd1-9eef-be987b721ec8"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("93ffef0a-5bca-4f8c-a064-9b5b6645d243"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("948f7b11-58f6-4fd8-8423-56ddaafe5b19"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a40caa46-f378-4b7e-b1fa-6ed9e90464fb"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("af6519d8-2163-46a6-b5ab-01706d1dc6f6"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("b4f4e2ae-7032-42fa-882c-47d8dece6532"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("cb48c089-f391-4913-a255-914d179e0be5"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("dbed867a-a607-4dd4-93aa-c71e4619e556"));

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Comments",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 5000);
        }
    }
}
