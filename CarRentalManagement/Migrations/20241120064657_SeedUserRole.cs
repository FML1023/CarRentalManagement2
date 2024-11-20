using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "6e37821a-a2b6-466e-a6f9-64bee98a242e", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEJKrkuBD7qMsJgDHLb93i+3WCC9wLSgF2x5t0NZsR7Wm/tfaYXli3zL9EXBI63ivVg==", null, false, "3e67955a-ce49-438d-9086-d7416bd61847", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 14, 46, 54, 837, DateTimeKind.Local).AddTicks(8484), new DateTime(2024, 11, 20, 14, 46, 54, 837, DateTimeKind.Local).AddTicks(8514) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 14, 46, 54, 837, DateTimeKind.Local).AddTicks(8521), new DateTime(2024, 11, 20, 14, 46, 54, 837, DateTimeKind.Local).AddTicks(8523) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 14, 46, 54, 837, DateTimeKind.Local).AddTicks(9116), new DateTime(2024, 11, 20, 14, 46, 54, 837, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 14, 46, 54, 837, DateTimeKind.Local).AddTicks(9123), new DateTime(2024, 11, 20, 14, 46, 54, 837, DateTimeKind.Local).AddTicks(9125) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 14, 46, 54, 837, DateTimeKind.Local).AddTicks(9361), new DateTime(2024, 11, 20, 14, 46, 54, 837, DateTimeKind.Local).AddTicks(9363) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 14, 46, 54, 837, DateTimeKind.Local).AddTicks(9369), new DateTime(2024, 11, 20, 14, 46, 54, 837, DateTimeKind.Local).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 14, 46, 54, 837, DateTimeKind.Local).AddTicks(9375), new DateTime(2024, 11, 20, 14, 46, 54, 837, DateTimeKind.Local).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 14, 46, 54, 837, DateTimeKind.Local).AddTicks(9381), new DateTime(2024, 11, 20, 14, 46, 54, 837, DateTimeKind.Local).AddTicks(9383) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 14, 39, 40, 638, DateTimeKind.Local).AddTicks(1117), new DateTime(2024, 11, 20, 14, 39, 40, 638, DateTimeKind.Local).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 14, 39, 40, 638, DateTimeKind.Local).AddTicks(1158), new DateTime(2024, 11, 20, 14, 39, 40, 638, DateTimeKind.Local).AddTicks(1160) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 14, 39, 40, 638, DateTimeKind.Local).AddTicks(1650), new DateTime(2024, 11, 20, 14, 39, 40, 638, DateTimeKind.Local).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 14, 39, 40, 638, DateTimeKind.Local).AddTicks(1657), new DateTime(2024, 11, 20, 14, 39, 40, 638, DateTimeKind.Local).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 14, 39, 40, 638, DateTimeKind.Local).AddTicks(1924), new DateTime(2024, 11, 20, 14, 39, 40, 638, DateTimeKind.Local).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 14, 39, 40, 638, DateTimeKind.Local).AddTicks(1932), new DateTime(2024, 11, 20, 14, 39, 40, 638, DateTimeKind.Local).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 14, 39, 40, 638, DateTimeKind.Local).AddTicks(1938), new DateTime(2024, 11, 20, 14, 39, 40, 638, DateTimeKind.Local).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 14, 39, 40, 638, DateTimeKind.Local).AddTicks(1944), new DateTime(2024, 11, 20, 14, 39, 40, 638, DateTimeKind.Local).AddTicks(1945) });
        }
    }
}
