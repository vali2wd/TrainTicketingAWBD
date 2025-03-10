using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrainTicketing.Database.Migrations
{
    /// <inheritdoc />
    public partial class RemoveFetesti : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("bd245552-935b-40a6-bf09-bdba25d09443"));

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "StationId", "StationName" },
                values: new object[] { new Guid("bd245552-935b-40a6-bf09-bdba25d09443"), "Fetesti" });
        }
    }
}
