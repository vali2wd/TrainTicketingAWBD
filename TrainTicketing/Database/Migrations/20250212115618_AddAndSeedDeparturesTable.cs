using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainTicketing.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddAndSeedDeparturesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartureId",
                table: "DepartureDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Departures",
                columns: table => new
                {
                    DepartureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departures", x => x.DepartureId);
                });

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "DepartureId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 2,
                column: "DepartureId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 3,
                column: "DepartureId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 4,
                column: "DepartureId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 5,
                column: "DepartureId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 6,
                column: "DepartureId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 7,
                column: "DepartureId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 8,
                column: "DepartureId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 9,
                column: "DepartureId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 10,
                column: "DepartureId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 11,
                column: "DepartureId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 12,
                column: "DepartureId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 13,
                column: "DepartureId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 14,
                column: "DepartureId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 15,
                column: "DepartureId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 16,
                column: "DepartureId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 17,
                column: "DepartureId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 18,
                column: "DepartureId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 19,
                column: "DepartureId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 20,
                column: "DepartureId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 21,
                column: "DepartureId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 22,
                column: "DepartureId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 23,
                column: "DepartureId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 24,
                column: "DepartureId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 25,
                column: "DepartureId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 26,
                column: "DepartureId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 27,
                column: "DepartureId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 28,
                column: "DepartureId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 29,
                column: "DepartureId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 30,
                column: "DepartureId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 31,
                column: "DepartureId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 32,
                column: "DepartureId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 33,
                column: "DepartureId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 34,
                column: "DepartureId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 35,
                column: "DepartureId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 36,
                column: "DepartureId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 37,
                column: "DepartureId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 38,
                column: "DepartureId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 39,
                column: "DepartureId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 40,
                column: "DepartureId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 41,
                column: "DepartureId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 42,
                column: "DepartureId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 43,
                column: "DepartureId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "DepartureDetails",
                keyColumn: "Id",
                keyValue: 44,
                column: "DepartureId",
                value: 4);

            migrationBuilder.InsertData(
                table: "Departures",
                column: "DepartureId",
                values: new object[]
                {
                    1,
                    2,
                    3,
                    4
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartureDetails_DepartureId",
                table: "DepartureDetails",
                column: "DepartureId");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartureDetails_Departures_DepartureId",
                table: "DepartureDetails",
                column: "DepartureId",
                principalTable: "Departures",
                principalColumn: "DepartureId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartureDetails_Departures_DepartureId",
                table: "DepartureDetails");

            migrationBuilder.DropTable(
                name: "Departures");

            migrationBuilder.DropIndex(
                name: "IX_DepartureDetails_DepartureId",
                table: "DepartureDetails");

            migrationBuilder.DropColumn(
                name: "DepartureId",
                table: "DepartureDetails");
        }
    }
}
