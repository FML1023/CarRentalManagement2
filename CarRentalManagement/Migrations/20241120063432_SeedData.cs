using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 20, 14, 34, 29, 667, DateTimeKind.Local).AddTicks(3023), new DateTime(2024, 11, 20, 14, 34, 29, 667, DateTimeKind.Local).AddTicks(3048), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 20, 14, 34, 29, 667, DateTimeKind.Local).AddTicks(3056), new DateTime(2024, 11, 20, 14, 34, 29, 667, DateTimeKind.Local).AddTicks(3057), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 20, 14, 34, 29, 667, DateTimeKind.Local).AddTicks(4430), new DateTime(2024, 11, 20, 14, 34, 29, 667, DateTimeKind.Local).AddTicks(4437), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 20, 14, 34, 29, 667, DateTimeKind.Local).AddTicks(4443), new DateTime(2024, 11, 20, 14, 34, 29, 667, DateTimeKind.Local).AddTicks(4444), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 20, 14, 34, 29, 667, DateTimeKind.Local).AddTicks(4674), new DateTime(2024, 11, 20, 14, 34, 29, 667, DateTimeKind.Local).AddTicks(4675), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 20, 14, 34, 29, 667, DateTimeKind.Local).AddTicks(6526), new DateTime(2024, 11, 20, 14, 34, 29, 667, DateTimeKind.Local).AddTicks(6567), "x5", "System" },
                    { 3, "System", new DateTime(2024, 11, 20, 14, 34, 29, 667, DateTimeKind.Local).AddTicks(6612), new DateTime(2024, 11, 20, 14, 34, 29, 667, DateTimeKind.Local).AddTicks(6614), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 20, 14, 34, 29, 667, DateTimeKind.Local).AddTicks(6619), new DateTime(2024, 11, 20, 14, 34, 29, 667, DateTimeKind.Local).AddTicks(6621), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
