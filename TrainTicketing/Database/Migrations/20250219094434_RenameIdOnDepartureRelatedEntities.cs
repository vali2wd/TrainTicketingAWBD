using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainTicketing.Database.Migrations
{
    /// <inheritdoc />
    public partial class RenameIdOnDepartureRelatedEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartureDates_Departures_DepartureId",
                table: "DepartureDates");

            migrationBuilder.RenameColumn(
                name: "DepartureIScheduleId",
                table: "Departures",
                newName: "DepartureScheduleId");

            migrationBuilder.RenameColumn(
                name: "DepartureId",
                table: "DepartureDates",
                newName: "DepartureScheduleId");

            migrationBuilder.RenameColumn(
                name: "DepartureDateId",
                table: "DepartureDates",
                newName: "DailyDepartureId");

            migrationBuilder.RenameIndex(
                name: "IX_DepartureDates_DepartureId",
                table: "DepartureDates",
                newName: "IX_DepartureDates_DepartureScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartureDates_Departures_DepartureScheduleId",
                table: "DepartureDates",
                column: "DepartureScheduleId",
                principalTable: "Departures",
                principalColumn: "DepartureScheduleId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartureDates_Departures_DepartureScheduleId",
                table: "DepartureDates");

            migrationBuilder.RenameColumn(
                name: "DepartureScheduleId",
                table: "Departures",
                newName: "DepartureIScheduleId");

            migrationBuilder.RenameColumn(
                name: "DepartureScheduleId",
                table: "DepartureDates",
                newName: "DepartureId");

            migrationBuilder.RenameColumn(
                name: "DailyDepartureId",
                table: "DepartureDates",
                newName: "DepartureDateId");

            migrationBuilder.RenameIndex(
                name: "IX_DepartureDates_DepartureScheduleId",
                table: "DepartureDates",
                newName: "IX_DepartureDates_DepartureId");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartureDates_Departures_DepartureId",
                table: "DepartureDates",
                column: "DepartureId",
                principalTable: "Departures",
                principalColumn: "DepartureIScheduleId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
