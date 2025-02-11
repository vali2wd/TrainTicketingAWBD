using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrainTicketing.Database.Migrations
{
    /// <inheritdoc />
    public partial class TariffRangesSeedings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "StartKm",
                table: "TariffRangess",
                type: "decimal(8,4)",
                precision: 8,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,1)",
                oldPrecision: 4,
                oldScale: 1);

            migrationBuilder.AlterColumn<decimal>(
                name: "PricePerKm",
                table: "TariffRangess",
                type: "decimal(8,4)",
                precision: 8,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,2)",
                oldPrecision: 2,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "EndKm",
                table: "TariffRangess",
                type: "decimal(8,4)",
                precision: 8,
                scale: 4,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,1)",
                oldPrecision: 4,
                oldScale: 1);

            migrationBuilder.InsertData(
                table: "TariffRangess",
                columns: new[] { "TariffRangeId", "EndKm", "PricePerKm", "SeatClass", "StartKm", "TariffSchemaId" },
                values: new object[,]
                {
                    { 1, 10m, 6.0m, 1, 1m, 1 },
                    { 2, 20m, 7.5m, 1, 11m, 1 },
                    { 3, 30m, 10.5m, 1, 21m, 1 },
                    { 4, 40m, 12.5m, 1, 31m, 1 },
                    { 5, 50m, 16.5m, 1, 41m, 1 },
                    { 6, 60m, 17.5m, 1, 51m, 1 },
                    { 7, 70m, 20.5m, 1, 61m, 1 },
                    { 8, 80m, 23.0m, 1, 71m, 1 },
                    { 9, 90m, 26.0m, 1, 81m, 1 },
                    { 10, 100m, 28.0m, 1, 91m, 1 },
                    { 11, 120m, 34.0m, 1, 101m, 1 },
                    { 12, 140m, 39.5m, 1, 121m, 1 },
                    { 13, 160m, 44.5m, 1, 141m, 1 },
                    { 14, 180m, 51.5m, 1, 161m, 1 },
                    { 15, 200m, 57.0m, 1, 181m, 1 },
                    { 16, 250m, 65.0m, 1, 201m, 1 },
                    { 17, 300m, 75.5m, 1, 251m, 1 },
                    { 18, 350m, 86.5m, 1, 301m, 1 },
                    { 19, 400m, 100.0m, 1, 351m, 1 },
                    { 20, 500m, 121.0m, 1, 401m, 1 },
                    { 21, null, 26.0m, 1, 501m, 1 },
                    { 22, 10m, 4.0m, 2, 1m, 1 },
                    { 23, 20m, 5.0m, 2, 11m, 1 },
                    { 24, 30m, 7.0m, 2, 21m, 1 },
                    { 25, 40m, 8.5m, 2, 31m, 1 },
                    { 26, 50m, 11.0m, 2, 41m, 1 },
                    { 27, 60m, 12.0m, 2, 51m, 1 },
                    { 28, 70m, 14.0m, 2, 61m, 1 },
                    { 29, 80m, 15.5m, 2, 71m, 1 },
                    { 30, 90m, 17.5m, 2, 81m, 1 },
                    { 31, 100m, 19.0m, 2, 91m, 1 },
                    { 32, 120m, 23.0m, 2, 101m, 1 },
                    { 33, 140m, 26.5m, 2, 121m, 1 },
                    { 34, 160m, 30.0m, 2, 141m, 1 },
                    { 35, 180m, 34.5m, 2, 161m, 1 },
                    { 36, 200m, 38.0m, 2, 181m, 1 },
                    { 37, 250m, 43.5m, 2, 201m, 1 },
                    { 38, 300m, 50.5m, 2, 251m, 1 },
                    { 39, 350m, 58.0m, 2, 301m, 1 },
                    { 40, 400m, 67.0m, 2, 351m, 1 },
                    { 41, 500m, 81.0m, 2, 401m, 1 },
                    { 42, null, 17.5m, 2, 501m, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "TariffRangess",
                keyColumn: "TariffRangeId",
                keyValue: 42);

            migrationBuilder.AlterColumn<decimal>(
                name: "StartKm",
                table: "TariffRangess",
                type: "decimal(4,1)",
                precision: 4,
                scale: 1,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,4)",
                oldPrecision: 8,
                oldScale: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "PricePerKm",
                table: "TariffRangess",
                type: "decimal(2,2)",
                precision: 2,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,4)",
                oldPrecision: 8,
                oldScale: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "EndKm",
                table: "TariffRangess",
                type: "decimal(4,1)",
                precision: 4,
                scale: 1,
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,4)",
                oldPrecision: 8,
                oldScale: 4,
                oldNullable: true);
        }
    }
}
