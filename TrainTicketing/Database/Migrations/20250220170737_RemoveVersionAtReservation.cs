using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainTicketing.Database.Migrations
{
    /// <inheritdoc />
    public partial class RemoveVersionAtReservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Version",
                table: "Reservations");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Version",
                table: "Reservations",
                type: "rowversion",
                rowVersion: true,
                nullable: true);
        }
    }
}
