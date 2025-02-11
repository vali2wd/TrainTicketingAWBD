using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrainTicketing.Database.Migrations
{
    /// <inheritdoc />
    public partial class RouteDetailsSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RouteDetails",
                columns: new[] { "Id", "DistanceFromMain", "OrderOfStationFromMain", "RouteId", "StationId" },
                values: new object[,]
                {
                    { 1, 0m, 0, new Guid("3dba6d64-acae-4cee-acff-630ef2b81d2a"), new Guid("8f1fd997-1261-450b-912f-8c90650e49d5") },
                    { 2, 31.3m, 1, new Guid("3dba6d64-acae-4cee-acff-630ef2b81d2a"), new Guid("08b824ab-8ac6-4b24-9872-95ff63b492bf") },
                    { 3, 45.0m, 2, new Guid("3dba6d64-acae-4cee-acff-630ef2b81d2a"), new Guid("0ed5992e-6dda-407a-8481-5233d26c64e0") },
                    { 4, 61.8m, 3, new Guid("3dba6d64-acae-4cee-acff-630ef2b81d2a"), new Guid("6ca13ae5-67f1-413b-b5c2-d89efc164c57") },
                    { 5, 94.3m, 4, new Guid("3dba6d64-acae-4cee-acff-630ef2b81d2a"), new Guid("41ff5b07-7ef4-4daf-b2e2-bb9d653d8245") },
                    { 6, 109m, 5, new Guid("3dba6d64-acae-4cee-acff-630ef2b81d2a"), new Guid("0bfcdb5d-163b-4576-b285-f360d6b5bcba") },
                    { 7, 124m, 6, new Guid("3dba6d64-acae-4cee-acff-630ef2b81d2a"), new Guid("62c14434-9039-412e-9e36-dcbd7cbbae4f") },
                    { 8, 130m, 7, new Guid("3dba6d64-acae-4cee-acff-630ef2b81d2a"), new Guid("33024dc9-bf84-4651-94bd-02a774f43c5b") },
                    { 9, 137m, 8, new Guid("3dba6d64-acae-4cee-acff-630ef2b81d2a"), new Guid("8daeb4c3-de43-4e5a-8e7e-f4645bb03441") },
                    { 10, 143m, 9, new Guid("3dba6d64-acae-4cee-acff-630ef2b81d2a"), new Guid("a831ce86-f068-4753-ba68-c3f9c9443605") },
                    { 11, 169m, 10, new Guid("3dba6d64-acae-4cee-acff-630ef2b81d2a"), new Guid("66a74a29-282f-4ff9-b5d6-2f49d3d3536f") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RouteDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RouteDetails",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RouteDetails",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RouteDetails",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RouteDetails",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RouteDetails",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RouteDetails",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RouteDetails",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RouteDetails",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RouteDetails",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "RouteDetails",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
