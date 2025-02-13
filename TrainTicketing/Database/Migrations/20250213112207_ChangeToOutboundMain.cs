using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainTicketing.Database.Migrations
{
    /// <inheritdoc />
    public partial class ChangeToOutboundMain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsAwayFromTerminal",
                table: "DepartureDetails",
                newName: "OutboundMain");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OutboundMain",
                table: "DepartureDetails",
                newName: "IsAwayFromTerminal");
        }
    }
}
