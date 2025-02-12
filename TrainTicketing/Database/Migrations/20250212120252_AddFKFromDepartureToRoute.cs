using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainTicketing.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddFKFromDepartureToRoute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "RouteId",
                table: "Departures",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Departures",
                keyColumn: "DepartureId",
                keyValue: 1,
                column: "RouteId",
                value: new Guid("3dba6d64-acae-4cee-acff-630ef2b81d2a"));

            migrationBuilder.UpdateData(
                table: "Departures",
                keyColumn: "DepartureId",
                keyValue: 2,
                column: "RouteId",
                value: new Guid("3dba6d64-acae-4cee-acff-630ef2b81d2a"));

            migrationBuilder.UpdateData(
                table: "Departures",
                keyColumn: "DepartureId",
                keyValue: 3,
                column: "RouteId",
                value: new Guid("3dba6d64-acae-4cee-acff-630ef2b81d2a"));

            migrationBuilder.UpdateData(
                table: "Departures",
                keyColumn: "DepartureId",
                keyValue: 4,
                column: "RouteId",
                value: new Guid("3dba6d64-acae-4cee-acff-630ef2b81d2a"));

            migrationBuilder.CreateIndex(
                name: "IX_Departures_RouteId",
                table: "Departures",
                column: "RouteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departures_Routes_RouteId",
                table: "Departures",
                column: "RouteId",
                principalTable: "Routes",
                principalColumn: "RouteId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departures_Routes_RouteId",
                table: "Departures");

            migrationBuilder.DropIndex(
                name: "IX_Departures_RouteId",
                table: "Departures");

            migrationBuilder.DropColumn(
                name: "RouteId",
                table: "Departures");
        }
    }
}
