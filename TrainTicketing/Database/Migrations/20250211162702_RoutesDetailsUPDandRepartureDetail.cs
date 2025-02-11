using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainTicketing.Database.Migrations
{
    /// <inheritdoc />
    public partial class RoutesDetailsUPDandRepartureDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "DistanceFromMain",
                table: "RouteDetails",
                type: "decimal(8,4)",
                precision: 8,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,1)",
                oldPrecision: 5,
                oldScale: 1);

            migrationBuilder.AddColumn<int>(
                name: "OrderOfStationFromMain",
                table: "RouteDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DepartureDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RouteDetailId = table.Column<int>(type: "int", nullable: false),
                    DepatureTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAwayFromTerminal = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartureDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepartureDetails_RouteDetails_RouteDetailId",
                        column: x => x.RouteDetailId,
                        principalTable: "RouteDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DepartureDetails_Trains_TrainId",
                        column: x => x.TrainId,
                        principalTable: "Trains",
                        principalColumn: "TrainId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartureDetails_RouteDetailId",
                table: "DepartureDetails",
                column: "RouteDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartureDetails_TrainId",
                table: "DepartureDetails",
                column: "TrainId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartureDetails");

            migrationBuilder.DropColumn(
                name: "OrderOfStationFromMain",
                table: "RouteDetails");

            migrationBuilder.AlterColumn<decimal>(
                name: "DistanceFromMain",
                table: "RouteDetails",
                type: "decimal(5,1)",
                precision: 5,
                scale: 1,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,4)",
                oldPrecision: 8,
                oldScale: 4);
        }
    }
}
