using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainTicketing.Database.Migrations
{
    /// <inheritdoc />
    public partial class RenameTablesOnDepartureRelatedEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartureDates_Departures_DepartureScheduleId",
                table: "DepartureDates");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartureDetails_Departures_DepartureId",
                table: "DepartureDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Departures_Routes_RouteId",
                table: "Departures");

            migrationBuilder.DropForeignKey(
                name: "FK_Departures_Trains_TrainId",
                table: "Departures");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Departures_DepartureId",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departures",
                table: "Departures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartureDates",
                table: "DepartureDates");

            migrationBuilder.RenameTable(
                name: "Departures",
                newName: "DepartureSchedules");

            migrationBuilder.RenameTable(
                name: "DepartureDates",
                newName: "DailyDepartures");

            migrationBuilder.RenameIndex(
                name: "IX_Departures_TrainId",
                table: "DepartureSchedules",
                newName: "IX_DepartureSchedules_TrainId");

            migrationBuilder.RenameIndex(
                name: "IX_Departures_RouteId",
                table: "DepartureSchedules",
                newName: "IX_DepartureSchedules_RouteId");

            migrationBuilder.RenameIndex(
                name: "IX_DepartureDates_DepartureScheduleId",
                table: "DailyDepartures",
                newName: "IX_DailyDepartures_DepartureScheduleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartureSchedules",
                table: "DepartureSchedules",
                column: "DepartureScheduleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DailyDepartures",
                table: "DailyDepartures",
                column: "DailyDepartureId");

            migrationBuilder.AddForeignKey(
                name: "FK_DailyDepartures_DepartureSchedules_DepartureScheduleId",
                table: "DailyDepartures",
                column: "DepartureScheduleId",
                principalTable: "DepartureSchedules",
                principalColumn: "DepartureScheduleId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartureDetails_DepartureSchedules_DepartureId",
                table: "DepartureDetails",
                column: "DepartureId",
                principalTable: "DepartureSchedules",
                principalColumn: "DepartureScheduleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartureSchedules_Routes_RouteId",
                table: "DepartureSchedules",
                column: "RouteId",
                principalTable: "Routes",
                principalColumn: "RouteId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartureSchedules_Trains_TrainId",
                table: "DepartureSchedules",
                column: "TrainId",
                principalTable: "Trains",
                principalColumn: "TrainId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_DepartureSchedules_DepartureId",
                table: "Reservations",
                column: "DepartureId",
                principalTable: "DepartureSchedules",
                principalColumn: "DepartureScheduleId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DailyDepartures_DepartureSchedules_DepartureScheduleId",
                table: "DailyDepartures");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartureDetails_DepartureSchedules_DepartureId",
                table: "DepartureDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartureSchedules_Routes_RouteId",
                table: "DepartureSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartureSchedules_Trains_TrainId",
                table: "DepartureSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_DepartureSchedules_DepartureId",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartureSchedules",
                table: "DepartureSchedules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DailyDepartures",
                table: "DailyDepartures");

            migrationBuilder.RenameTable(
                name: "DepartureSchedules",
                newName: "Departures");

            migrationBuilder.RenameTable(
                name: "DailyDepartures",
                newName: "DepartureDates");

            migrationBuilder.RenameIndex(
                name: "IX_DepartureSchedules_TrainId",
                table: "Departures",
                newName: "IX_Departures_TrainId");

            migrationBuilder.RenameIndex(
                name: "IX_DepartureSchedules_RouteId",
                table: "Departures",
                newName: "IX_Departures_RouteId");

            migrationBuilder.RenameIndex(
                name: "IX_DailyDepartures_DepartureScheduleId",
                table: "DepartureDates",
                newName: "IX_DepartureDates_DepartureScheduleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departures",
                table: "Departures",
                column: "DepartureScheduleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartureDates",
                table: "DepartureDates",
                column: "DailyDepartureId");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartureDates_Departures_DepartureScheduleId",
                table: "DepartureDates",
                column: "DepartureScheduleId",
                principalTable: "Departures",
                principalColumn: "DepartureScheduleId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartureDetails_Departures_DepartureId",
                table: "DepartureDetails",
                column: "DepartureId",
                principalTable: "Departures",
                principalColumn: "DepartureScheduleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departures_Routes_RouteId",
                table: "Departures",
                column: "RouteId",
                principalTable: "Routes",
                principalColumn: "RouteId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Departures_Trains_TrainId",
                table: "Departures",
                column: "TrainId",
                principalTable: "Trains",
                principalColumn: "TrainId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Departures_DepartureId",
                table: "Reservations",
                column: "DepartureId",
                principalTable: "Departures",
                principalColumn: "DepartureScheduleId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
