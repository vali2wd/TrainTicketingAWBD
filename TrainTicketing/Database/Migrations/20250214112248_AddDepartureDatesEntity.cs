using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrainTicketing.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddDepartureDatesEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DepartureDates",
                columns: table => new
                {
                    DepartureDateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfDeparture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartureDates", x => x.DepartureDateId);
                    table.ForeignKey(
                        name: "FK_DepartureDates_Departures_DepartureId",
                        column: x => x.DepartureId,
                        principalTable: "Departures",
                        principalColumn: "DepartureId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "DepartureDates",
                columns: new[] { "DepartureDateId", "DateOfDeparture", "DepartureId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 5, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 7, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 8, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 9, new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10, new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartureDates_DepartureId",
                table: "DepartureDates",
                column: "DepartureId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartureDates");
        }
    }
}
