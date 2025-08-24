using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "CreatedAt", "Title" },
                values: new object[,]
                {
                    { 1, "went hiking with Guru", new DateTime(2025, 8, 22, 2, 29, 53, 193, DateTimeKind.Local).AddTicks(2854), "Went hiking" },
                    { 2, "went cluping with Guru", new DateTime(2025, 8, 22, 2, 29, 53, 193, DateTimeKind.Local).AddTicks(2865), "Went Clubing" },
                    { 3, "went shopping with Guru", new DateTime(2025, 8, 22, 2, 29, 53, 193, DateTimeKind.Local).AddTicks(2874), "Went Shopping" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
