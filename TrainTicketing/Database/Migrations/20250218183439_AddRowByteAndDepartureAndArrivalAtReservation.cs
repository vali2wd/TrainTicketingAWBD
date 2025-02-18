using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainTicketing.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddRowByteAndDepartureAndArrivalAtReservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArrivalStationRouteDetailId",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartureStationRouteDetailId",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "Version",
                table: "Reservations",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ArrivalStationRouteDetailId",
                table: "Reservations",
                column: "ArrivalStationRouteDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_DepartureStationRouteDetailId",
                table: "Reservations",
                column: "DepartureStationRouteDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_RouteDetails_ArrivalStationRouteDetailId",
                table: "Reservations",
                column: "ArrivalStationRouteDetailId",
                principalTable: "RouteDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_RouteDetails_DepartureStationRouteDetailId",
                table: "Reservations",
                column: "DepartureStationRouteDetailId",
                principalTable: "RouteDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_RouteDetails_ArrivalStationRouteDetailId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_RouteDetails_DepartureStationRouteDetailId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ArrivalStationRouteDetailId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_DepartureStationRouteDetailId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ArrivalStationRouteDetailId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "DepartureStationRouteDetailId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "Version",
                table: "Reservations");
        }
    }
}
