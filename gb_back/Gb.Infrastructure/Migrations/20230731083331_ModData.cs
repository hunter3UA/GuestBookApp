using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Gb.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Comments",
                type: "nvarchar(max)",
                maxLength: 10000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Name", "Text" },
                values: new object[,]
                {
                    { new Guid("01328ed4-60cd-43bd-8691-ed9a0c300503"), "Jakob", "Not bad, everything is ok!" },
                    { new Guid("02e9970c-1927-49eb-bcb1-428b7b2d6d1f"), "Bred", "This is nice place!" },
                    { new Guid("0b9faf0f-af06-4c28-9e28-f4b3713d1b01"), "Jim", "Everything is fine" },
                    { new Guid("11aeed30-8ded-4b46-ab21-ed7fd425c39a"), "Ann", "Niccccccccccccccccceeeeeeeeeeeee" },
                    { new Guid("1621d240-401d-4420-9393-0fbaba633f63"), "Ron", "Good place, i will come again" },
                    { new Guid("198009d2-bab7-4920-b80e-ea12503e2420"), "John", "This is nice place!" },
                    { new Guid("33d24a8f-b9a5-4f55-9781-60b79d2c722a"), "Jason", "This is nice place!" },
                    { new Guid("3c2db40f-92e9-4113-95c0-d7b2d6de7e9d"), "Enthony", "Good place, i will come again" },
                    { new Guid("665c6d9b-c3f6-4333-a4a4-fe02a9394c0f"), "Sam", "You should visit this place" },
                    { new Guid("a1e74d45-c4de-46ea-9589-91c7f2b86b03"), "Alice", "This is the best place i have ever seen" },
                    { new Guid("a7add580-632e-4a53-83d1-df9bc8c983e2"), "Andy", "You should visit this place" },
                    { new Guid("e2353fbb-6920-4c32-9a99-9b50ffab2cc2"), "Susan", "You should visit this place" },
                    { new Guid("e3bbc408-09f9-4306-b45f-7d7cb1864c9f"), "James", "Not bad, everything is ok!" },
                    { new Guid("f99e743d-d194-477f-aa29-07c5a0353a2d"), "Alex", "This is the best place i have ever seen" },
                    { new Guid("fcdb7df2-d708-4c37-bf34-bac22dea0e03"), "Ray", "Everything is fine" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("01328ed4-60cd-43bd-8691-ed9a0c300503"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("02e9970c-1927-49eb-bcb1-428b7b2d6d1f"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("0b9faf0f-af06-4c28-9e28-f4b3713d1b01"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("11aeed30-8ded-4b46-ab21-ed7fd425c39a"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("1621d240-401d-4420-9393-0fbaba633f63"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("198009d2-bab7-4920-b80e-ea12503e2420"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("33d24a8f-b9a5-4f55-9781-60b79d2c722a"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("3c2db40f-92e9-4113-95c0-d7b2d6de7e9d"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("665c6d9b-c3f6-4333-a4a4-fe02a9394c0f"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a1e74d45-c4de-46ea-9589-91c7f2b86b03"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a7add580-632e-4a53-83d1-df9bc8c983e2"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("e2353fbb-6920-4c32-9a99-9b50ffab2cc2"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("e3bbc408-09f9-4306-b45f-7d7cb1864c9f"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f99e743d-d194-477f-aa29-07c5a0353a2d"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("fcdb7df2-d708-4c37-bf34-bac22dea0e03"));

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Comments",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 10000);
        }
    }
}
