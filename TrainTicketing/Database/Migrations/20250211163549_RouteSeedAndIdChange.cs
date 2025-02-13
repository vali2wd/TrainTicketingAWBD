using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainTicketing.Database.Migrations
{
    /// <inheritdoc />
    public partial class RouteSeedAndIdChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Routes",
                newName: "RouteId");

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteId", "ImagePath", "MainTerminalId", "RouteName", "TariffSchemaId" },
                values: new object[] { new Guid("3dba6d64-acae-4cee-acff-630ef2b81d2a"), "https://trainticketing.blob.core.windows.net/trainticketingimages/ruta_Bucuresti-Brasov.png", new Guid("8f1fd997-1261-450b-912f-8c90650e49d5"), "Bucuresti-Brasov", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Routes",
                keyColumn: "RouteId",
                keyValue: new Guid("3dba6d64-acae-4cee-acff-630ef2b81d2a"));

            migrationBuilder.RenameColumn(
                name: "RouteId",
                table: "Routes",
                newName: "Id");
        }
    }
}
