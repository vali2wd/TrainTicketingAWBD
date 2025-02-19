using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainTicketing.Database.Migrations
{
    /// <inheritdoc />
    public partial class RenameDepartureRelatedEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepartureId",
                table: "Departures",
                newName: "DepartureIScheduleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepartureIScheduleId",
                table: "Departures",
                newName: "DepartureId");
        }
    }
}
