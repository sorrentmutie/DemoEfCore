using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddGenresMutiple : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Birthday", "Name", "Salary" },
                values: new object[,]
                {
                    { 11, new DateTime(1983, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe", 1500000m },
                    { 12, new DateTime(1968, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luigi Bianchi", 500000m },
                    { 13, new DateTime(1975, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mario Rossi", 800000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 13);
        }
    }
}
