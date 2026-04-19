using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrainTicketing.Database.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoreRoutes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteId", "ImagePath", "MainTerminalId", "RouteName", "TariffSchemaId", "TotalDistance" },
                values: new object[,]
                {
                    { new Guid("1e55a13b-1ce5-4370-bf93-8851415ddedb"), "https://trainticketing.blob.core.windows.net/trainticketingimages/ruta_Bucuresti-Brasov.png", new Guid("8f1fd997-1261-450b-912f-8c90650e49d5"), "Ruta1e55a13b-1ce5-4370", 1, 169.0m },
                    { new Guid("3757cae8-6223-4c2c-b23c-d514173c449b"), "https://trainticketing.blob.core.windows.net/trainticketingimages/ruta_Bucuresti-Brasov.png", new Guid("8f1fd997-1261-450b-912f-8c90650e49d5"), "Ruta3757cae8-6223-4c2c", 1, 169.0m },
                    { new Guid("4b13c88b-9c49-4177-91c9-76648b8c8231"), "https://trainticketing.blob.core.windows.net/trainticketingimages/ruta_Bucuresti-Brasov.png", new Guid("8f1fd997-1261-450b-912f-8c90650e49d5"), "Ruta4b13c88b-9c49-4177", 1, 169.0m },
                    { new Guid("6cf15bf2-db1a-4874-b2c7-9be7110eaaf0"), "https://trainticketing.blob.core.windows.net/trainticketingimages/ruta_Bucuresti-Brasov.png", new Guid("8f1fd997-1261-450b-912f-8c90650e49d5"), "Ruta6cf15bf2-db1a-4874", 1, 169.0m },
                    { new Guid("7756bfd1-4020-4193-a342-562d20509df8"), "https://trainticketing.blob.core.windows.net/trainticketingimages/ruta_Bucuresti-Brasov.png", new Guid("8f1fd997-1261-450b-912f-8c90650e49d5"), "Ruta7756bfd1-4020-4193", 1, 169.0m },
                    { new Guid("e19ada88-c110-4f0f-96ce-ef1ce0bd1738"), "https://trainticketing.blob.core.windows.net/trainticketingimages/ruta_Bucuresti-Brasov.png", new Guid("8f1fd997-1261-450b-912f-8c90650e49d5"), "Rutae19ada88-c110-4f0f", 1, 169.0m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "RouteId",
                keyValue: new Guid("1e55a13b-1ce5-4370-bf93-8851415ddedb"));

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "RouteId",
                keyValue: new Guid("3757cae8-6223-4c2c-b23c-d514173c449b"));

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "RouteId",
                keyValue: new Guid("4b13c88b-9c49-4177-91c9-76648b8c8231"));

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "RouteId",
                keyValue: new Guid("6cf15bf2-db1a-4874-b2c7-9be7110eaaf0"));

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "RouteId",
                keyValue: new Guid("7756bfd1-4020-4193-a342-562d20509df8"));

            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "RouteId",
                keyValue: new Guid("e19ada88-c110-4f0f-96ce-ef1ce0bd1738"));
        }
    }
}
