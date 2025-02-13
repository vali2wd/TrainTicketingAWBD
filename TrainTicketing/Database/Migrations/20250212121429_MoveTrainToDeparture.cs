using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainTicketing.Database.Migrations
{
    /// <inheritdoc />
    public partial class MoveTrainToDeparture : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartureDetails_Trains_TrainId",
                table: "DepartureDetails");

            migrationBuilder.DropIndex(
                name: "IX_DepartureDetails_TrainId",
                table: "DepartureDetails");

            migrationBuilder.DropColumn(
                name: "TrainId",
                table: "DepartureDetails");

            migrationBuilder.AddColumn<Guid>(
                name: "TrainId",
                table: "Departures",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Departures",
                keyColumn: "DepartureId",
                keyValue: 1,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "Departures",
                keyColumn: "DepartureId",
                keyValue: 2,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "Departures",
                keyColumn: "DepartureId",
                keyValue: 3,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "Departures",
                keyColumn: "DepartureId",
                keyValue: 4,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.CreateIndex(
                name: "IX_Departures_TrainId",
                table: "Departures",
                column: "TrainId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departures_Trains_TrainId",
                table: "Departures",
                column: "TrainId",
                principalTable: "Trains",
                principalColumn: "TrainId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departures_Trains_TrainId",
                table: "Departures");

            migrationBuilder.DropIndex(
                name: "IX_Departures_TrainId",
                table: "Departures");

            migrationBuilder.DropColumn(
                name: "TrainId",
                table: "Departures");

            migrationBuilder.AddColumn<Guid>(
                name: "TrainId",
                table: "DepartureDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 5,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 6,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 7,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 8,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 9,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 10,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 11,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 12,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 13,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 14,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 15,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 16,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 17,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 18,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 19,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 20,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 21,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 22,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 23,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 24,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 25,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 26,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 27,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 28,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 29,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 30,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 31,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 32,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 33,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 34,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 35,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 36,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 37,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 38,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 39,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 40,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 41,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 42,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 43,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 44,
                column: "TrainId",
                value: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.CreateIndex(
                name: "IX_DepartureDetails_TrainId",
                table: "DepartureDetails",
                column: "TrainId");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartureDetails_Trains_TrainId",
                table: "DepartureDetails",
                column: "TrainId",
                principalTable: "Trains",
                principalColumn: "TrainId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
