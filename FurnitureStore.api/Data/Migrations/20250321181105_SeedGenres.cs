using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FurnitureStore.api.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedGenres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Garden table" },
                    { 2, "Garden chair" },
                    { 3, "Hammock" },
                    { 4, "Bench" },
                    { 5, "Bed" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FTypes",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
