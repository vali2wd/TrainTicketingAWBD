using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrainTicketing.Database.Migrations
{
    /// <inheritdoc />
    public partial class SeedDepartureDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "DepatureTime",
                table: "DepartureDetails",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "DepartureDetails",
                columns: new[] { "Id", "DepatureTime", "IsAwayFromTerminal", "RouteDetailId", "TrainId" },
                values: new object[,]
                {
                    { 1, new TimeSpan(0, 7, 0, 0, 0), true, 1, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 2, new TimeSpan(0, 7, 20, 0, 0), true, 2, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 3, new TimeSpan(0, 7, 30, 0, 0), true, 3, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 4, new TimeSpan(0, 7, 42, 0, 0), true, 4, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 5, new TimeSpan(0, 8, 6, 0, 0), true, 5, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 6, new TimeSpan(0, 8, 18, 0, 0), true, 6, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 7, new TimeSpan(0, 8, 35, 0, 0), true, 7, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 8, new TimeSpan(0, 8, 44, 0, 0), true, 8, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 9, new TimeSpan(0, 8, 50, 0, 0), true, 9, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 10, new TimeSpan(0, 9, 0, 0, 0), true, 10, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 11, new TimeSpan(0, 9, 33, 0, 0), true, 11, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 12, new TimeSpan(0, 12, 39, 0, 0), false, 1, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 13, new TimeSpan(0, 12, 30, 0, 0), false, 2, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 14, new TimeSpan(0, 12, 20, 0, 0), false, 3, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 15, new TimeSpan(0, 12, 0, 0, 0), false, 4, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 16, new TimeSpan(0, 11, 33, 0, 0), false, 5, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 17, new TimeSpan(0, 11, 18, 0, 0), false, 6, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 18, new TimeSpan(0, 11, 3, 0, 0), false, 7, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 19, new TimeSpan(0, 10, 53, 0, 0), false, 8, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 20, new TimeSpan(0, 10, 46, 0, 0), false, 9, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 21, new TimeSpan(0, 10, 36, 0, 0), false, 10, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 22, new TimeSpan(0, 9, 56, 0, 0), false, 11, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 23, new TimeSpan(0, 15, 0, 0, 0), true, 1, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 24, new TimeSpan(0, 15, 20, 0, 0), true, 2, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 25, new TimeSpan(0, 15, 30, 0, 0), true, 3, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 26, new TimeSpan(0, 15, 42, 0, 0), true, 4, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 27, new TimeSpan(0, 16, 6, 0, 0), true, 5, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 28, new TimeSpan(0, 16, 18, 0, 0), true, 6, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 29, new TimeSpan(0, 16, 35, 0, 0), true, 7, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 30, new TimeSpan(0, 16, 44, 0, 0), true, 8, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 31, new TimeSpan(0, 16, 50, 0, 0), true, 9, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 32, new TimeSpan(0, 17, 0, 0, 0), true, 10, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 33, new TimeSpan(0, 17, 33, 0, 0), true, 11, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 34, new TimeSpan(0, 20, 39, 0, 0), false, 1, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 35, new TimeSpan(0, 20, 30, 0, 0), false, 2, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 36, new TimeSpan(0, 20, 20, 0, 0), false, 3, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 37, new TimeSpan(0, 20, 0, 0, 0), false, 4, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 38, new TimeSpan(0, 19, 33, 0, 0), false, 5, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 39, new TimeSpan(0, 19, 18, 0, 0), false, 6, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 40, new TimeSpan(0, 19, 3, 0, 0), false, 7, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 41, new TimeSpan(0, 18, 53, 0, 0), false, 8, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 42, new TimeSpan(0, 18, 46, 0, 0), false, 9, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 43, new TimeSpan(0, 18, 36, 0, 0), false, 10, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 44, new TimeSpan(0, 17, 56, 0, 0), false, 11, new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DepatureTime",
                table: "DepartureDetails",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");
        }
    }
}
