using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainTicketing.Database.Migrations
{
    /// <inheritdoc />
    public partial class MoveOutboundMainToDeparture : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OutboundMain",
                table: "DepartureDetails");

            migrationBuilder.AddColumn<bool>(
                name: "OutboundMain",
                table: "Departures",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Departures",
                keyColumn: "DepartureId",
                keyValue: 1,
                column: "OutboundMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "Departures",
                keyColumn: "DepartureId",
                keyValue: 2,
                column: "OutboundMain",
                value: false);

            migrationBuilder.UpdateData(
                table: "Departures",
                keyColumn: "DepartureId",
                keyValue: 3,
                column: "OutboundMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "Departures",
                keyColumn: "DepartureId",
                keyValue: 4,
                column: "OutboundMain",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OutboundMain",
                table: "Departures");

            migrationBuilder.AddColumn<bool>(
                name: "OutboundMain",
                table: "DepartureDetails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "OutboundMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "OutboundMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "OutboundMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "OutboundMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 5,
                column: "OutboundMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 6,
                column: "OutboundMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 7,
                column: "OutboundMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 8,
                column: "OutboundMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 9,
                column: "OutboundMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 10,
                column: "OutboundMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 11,
                column: "OutboundMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 12,
                column: "OutboundMain",
                value: false);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 13,
                column: "OutboundMain",
                value: false);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 14,
                column: "OutboundMain",
                value: false);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 15,
                column: "OutboundMain",
                value: false);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 16,
                column: "OutboundMain",
                value: false);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 17,
                column: "OutboundMain",
                value: false);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 18,
                column: "OutboundMain",
                value: false);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 19,
                column: "OutboundMain",
                value: false);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 20,
                column: "OutboundMain",
                value: false);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 21,
                column: "OutboundMain",
                value: false);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 22,
                column: "OutboundMain",
                value: false);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 23,
                column: "OutboundMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 24,
                column: "OutboundMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 25,
                column: "OutboundMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 26,
                column: "OutboundMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 27,
                column: "OutboundMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 28,
                column: "OutboundMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 29,
                column: "OutboundMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 30,
                column: "OutboundMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 31,
                column: "OutboundMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 32,
                column: "OutboundMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 33,
                column: "OutboundMain",
                value: true);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 34,
                column: "OutboundMain",
                value: false);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 35,
                column: "OutboundMain",
                value: false);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 36,
                column: "OutboundMain",
                value: false);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 37,
                column: "OutboundMain",
                value: false);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 38,
                column: "OutboundMain",
                value: false);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 39,
                column: "OutboundMain",
                value: false);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 40,
                column: "OutboundMain",
                value: false);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 41,
                column: "OutboundMain",
                value: false);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 42,
                column: "OutboundMain",
                value: false);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 43,
                column: "OutboundMain",
                value: false);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 44,
                column: "OutboundMain",
                value: false);
        }
    }
}
