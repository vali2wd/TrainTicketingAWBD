using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrainTicketing.Database.Migrations
{
    /// <inheritdoc />
    public partial class TrainAndSeatsSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Trains_TrainId1",
                table: "Seats");

            migrationBuilder.DropIndex(
                name: "IX_Seats_TrainId1",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "TrainId1",
                table: "Seats");

            migrationBuilder.InsertData(
                table: "Trains",
                columns: new[] { "TrainId", "TrainName", "TrainType" },
                values: new object[,]
                {
                    { new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb"), "Nightliner E", 1 },
                    { new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), "Express A", 1 },
                    { new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350"), "Local D", 0 },
                    { new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b"), "Superfast C", 1 },
                    { new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c"), "Regional B", 0 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "SeatId", "SeatClass", "SeatCode", "TrainId" },
                values: new object[,]
                {
                    { 1, 1, "1", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 2, 1, "2", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 3, 1, "3", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 4, 1, "4", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 5, 1, "5", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 6, 1, "6", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 7, 1, "7", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 8, 1, "8", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 9, 1, "9", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 10, 1, "10", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 11, 1, "11", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 12, 1, "12", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 13, 1, "13", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 14, 1, "14", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 15, 1, "15", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 16, 1, "16", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 17, 1, "17", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 18, 1, "18", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 19, 1, "19", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 20, 1, "20", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 21, 1, "21", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 22, 1, "22", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 23, 1, "23", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 24, 1, "24", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 25, 1, "25", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 26, 1, "26", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 27, 1, "27", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 28, 1, "28", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 29, 1, "29", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 30, 1, "30", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 31, 1, "31", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 32, 1, "32", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 33, 1, "33", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 34, 1, "34", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 35, 1, "35", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 36, 1, "36", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 37, 1, "37", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 38, 1, "38", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 39, 1, "39", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 40, 1, "40", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 41, 1, "41", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 42, 1, "42", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 43, 1, "43", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 44, 1, "44", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 45, 1, "45", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 46, 1, "46", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 47, 1, "47", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 48, 1, "48", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 49, 1, "49", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 50, 1, "50", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 51, 1, "51", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 52, 1, "52", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 53, 1, "53", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 54, 1, "54", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 55, 1, "55", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 56, 1, "56", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 57, 1, "57", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 58, 1, "58", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 59, 1, "59", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 60, 1, "60", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 61, 1, "61", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 62, 1, "62", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 63, 1, "63", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 64, 1, "64", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 65, 2, "65", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 66, 2, "66", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 67, 2, "67", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 68, 2, "68", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 69, 2, "69", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 70, 2, "70", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 71, 2, "71", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 72, 2, "72", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 73, 2, "73", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 74, 2, "74", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 75, 2, "75", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 76, 2, "76", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 77, 2, "77", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 78, 2, "78", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 79, 2, "79", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 80, 2, "80", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 81, 2, "81", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 82, 2, "82", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 83, 2, "83", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 84, 2, "84", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 85, 2, "85", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 86, 2, "86", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 87, 2, "87", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 88, 2, "88", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 89, 2, "89", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 90, 2, "90", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 91, 2, "91", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 92, 2, "92", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 93, 2, "93", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 94, 2, "94", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 95, 2, "95", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 96, 2, "96", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 97, 2, "97", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 98, 2, "98", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 99, 2, "99", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 100, 2, "100", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 101, 2, "101", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 102, 2, "102", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 103, 2, "103", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 104, 2, "104", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 105, 2, "105", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 106, 2, "106", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 107, 2, "107", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 108, 2, "108", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 109, 2, "109", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 110, 2, "110", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 111, 2, "111", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 112, 2, "112", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 113, 2, "113", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 114, 2, "114", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 115, 2, "115", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 116, 2, "116", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 117, 2, "117", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 118, 2, "118", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 119, 2, "119", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 120, 2, "120", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 121, 2, "121", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 122, 2, "122", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 123, 2, "123", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 124, 2, "124", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 125, 2, "125", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 126, 2, "126", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 127, 2, "127", new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 128, 1, "1", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 129, 1, "2", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 130, 1, "3", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 131, 1, "4", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 132, 1, "5", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 133, 1, "6", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 134, 1, "7", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 135, 1, "8", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 136, 1, "9", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 137, 1, "10", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 138, 1, "11", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 139, 1, "12", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 140, 1, "13", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 141, 1, "14", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 142, 1, "15", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 143, 1, "16", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 144, 1, "17", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 145, 1, "18", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 146, 1, "19", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 147, 1, "20", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 148, 1, "21", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 149, 1, "22", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 150, 1, "23", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 151, 1, "24", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 152, 1, "25", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 153, 1, "26", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 154, 1, "27", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 155, 1, "28", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 156, 1, "29", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 157, 1, "30", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 158, 1, "31", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 159, 1, "32", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 160, 1, "33", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 161, 1, "34", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 162, 1, "35", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 163, 1, "36", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 164, 1, "37", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 165, 1, "38", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 166, 1, "39", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 167, 1, "40", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 168, 1, "41", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 169, 1, "42", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 170, 1, "43", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 171, 1, "44", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 172, 1, "45", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 173, 1, "46", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 174, 1, "47", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 175, 1, "48", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 176, 1, "49", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 177, 1, "50", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 178, 1, "51", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 179, 1, "52", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 180, 1, "53", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 181, 1, "54", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 182, 1, "55", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 183, 1, "56", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 184, 1, "57", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 185, 1, "58", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 186, 1, "59", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 187, 1, "60", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 188, 1, "61", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 189, 1, "62", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 190, 1, "63", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 191, 1, "64", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 192, 2, "65", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 193, 2, "66", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 194, 2, "67", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 195, 2, "68", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 196, 2, "69", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 197, 2, "70", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 198, 2, "71", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 199, 2, "72", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 200, 2, "73", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 201, 2, "74", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 202, 2, "75", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 203, 2, "76", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 204, 2, "77", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 205, 2, "78", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 206, 2, "79", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 207, 2, "80", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 208, 2, "81", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 209, 2, "82", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 210, 2, "83", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 211, 2, "84", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 212, 2, "85", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 213, 2, "86", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 214, 2, "87", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 215, 2, "88", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 216, 2, "89", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 217, 2, "90", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 218, 2, "91", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 219, 2, "92", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 220, 2, "93", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 221, 2, "94", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 222, 2, "95", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 223, 2, "96", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 224, 2, "97", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 225, 2, "98", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 226, 2, "99", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 227, 2, "100", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 228, 2, "101", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 229, 2, "102", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 230, 2, "103", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 231, 2, "104", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 232, 2, "105", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 233, 2, "106", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 234, 2, "107", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 235, 2, "108", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 236, 2, "109", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 237, 2, "110", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 238, 2, "111", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 239, 2, "112", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 240, 2, "113", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 241, 2, "114", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 242, 2, "115", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 243, 2, "116", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 244, 2, "117", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 245, 2, "118", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 246, 2, "119", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 247, 2, "120", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 248, 2, "121", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 249, 2, "122", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 250, 2, "123", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 251, 2, "124", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 252, 2, "125", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 253, 2, "126", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 254, 2, "127", new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c") },
                    { 255, 1, "1", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 256, 1, "2", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 257, 1, "3", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 258, 1, "4", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 259, 1, "5", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 260, 1, "6", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 261, 1, "7", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 262, 1, "8", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 263, 1, "9", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 264, 1, "10", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 265, 1, "11", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 266, 1, "12", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 267, 1, "13", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 268, 1, "14", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 269, 1, "15", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 270, 1, "16", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 271, 1, "17", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 272, 1, "18", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 273, 1, "19", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 274, 1, "20", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 275, 1, "21", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 276, 1, "22", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 277, 1, "23", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 278, 1, "24", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 279, 1, "25", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 280, 1, "26", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 281, 1, "27", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 282, 1, "28", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 283, 1, "29", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 284, 1, "30", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 285, 1, "31", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 286, 1, "32", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 287, 1, "33", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 288, 1, "34", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 289, 1, "35", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 290, 1, "36", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 291, 1, "37", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 292, 1, "38", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 293, 1, "39", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 294, 1, "40", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 295, 1, "41", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 296, 1, "42", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 297, 1, "43", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 298, 1, "44", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 299, 1, "45", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 300, 1, "46", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 301, 1, "47", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 302, 1, "48", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 303, 1, "49", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 304, 1, "50", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 305, 1, "51", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 306, 1, "52", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 307, 1, "53", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 308, 1, "54", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 309, 1, "55", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 310, 1, "56", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 311, 1, "57", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 312, 1, "58", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 313, 1, "59", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 314, 1, "60", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 315, 1, "61", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 316, 1, "62", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 317, 1, "63", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 318, 1, "64", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 319, 2, "65", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 320, 2, "66", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 321, 2, "67", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 322, 2, "68", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 323, 2, "69", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 324, 2, "70", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 325, 2, "71", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 326, 2, "72", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 327, 2, "73", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 328, 2, "74", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 329, 2, "75", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 330, 2, "76", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 331, 2, "77", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 332, 2, "78", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 333, 2, "79", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 334, 2, "80", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 335, 2, "81", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 336, 2, "82", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 337, 2, "83", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 338, 2, "84", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 339, 2, "85", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 340, 2, "86", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 341, 2, "87", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 342, 2, "88", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 343, 2, "89", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 344, 2, "90", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 345, 2, "91", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 346, 2, "92", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 347, 2, "93", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 348, 2, "94", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 349, 2, "95", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 350, 2, "96", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 351, 2, "97", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 352, 2, "98", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 353, 2, "99", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 354, 2, "100", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 355, 2, "101", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 356, 2, "102", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 357, 2, "103", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 358, 2, "104", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 359, 2, "105", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 360, 2, "106", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 361, 2, "107", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 362, 2, "108", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 363, 2, "109", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 364, 2, "110", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 365, 2, "111", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 366, 2, "112", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 367, 2, "113", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 368, 2, "114", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 369, 2, "115", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 370, 2, "116", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 371, 2, "117", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 372, 2, "118", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 373, 2, "119", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 374, 2, "120", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 375, 2, "121", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 376, 2, "122", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 377, 2, "123", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 378, 2, "124", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 379, 2, "125", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 380, 2, "126", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 381, 2, "127", new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b") },
                    { 382, 1, "1", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 383, 1, "2", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 384, 1, "3", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 385, 1, "4", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 386, 1, "5", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 387, 1, "6", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 388, 1, "7", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 389, 1, "8", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 390, 1, "9", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 391, 1, "10", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 392, 1, "11", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 393, 1, "12", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 394, 1, "13", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 395, 1, "14", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 396, 1, "15", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 397, 1, "16", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 398, 1, "17", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 399, 1, "18", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 400, 1, "19", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 401, 1, "20", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 402, 1, "21", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 403, 1, "22", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 404, 1, "23", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 405, 1, "24", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 406, 1, "25", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 407, 1, "26", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 408, 1, "27", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 409, 1, "28", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 410, 1, "29", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 411, 1, "30", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 412, 1, "31", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 413, 1, "32", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 414, 1, "33", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 415, 1, "34", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 416, 1, "35", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 417, 1, "36", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 418, 1, "37", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 419, 1, "38", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 420, 1, "39", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 421, 1, "40", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 422, 1, "41", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 423, 1, "42", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 424, 1, "43", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 425, 1, "44", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 426, 1, "45", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 427, 1, "46", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 428, 1, "47", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 429, 1, "48", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 430, 1, "49", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 431, 1, "50", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 432, 1, "51", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 433, 1, "52", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 434, 1, "53", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 435, 1, "54", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 436, 1, "55", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 437, 1, "56", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 438, 1, "57", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 439, 1, "58", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 440, 1, "59", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 441, 1, "60", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 442, 1, "61", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 443, 1, "62", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 444, 1, "63", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 445, 1, "64", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 446, 2, "65", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 447, 2, "66", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 448, 2, "67", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 449, 2, "68", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 450, 2, "69", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 451, 2, "70", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 452, 2, "71", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 453, 2, "72", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 454, 2, "73", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 455, 2, "74", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 456, 2, "75", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 457, 2, "76", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 458, 2, "77", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 459, 2, "78", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 460, 2, "79", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 461, 2, "80", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 462, 2, "81", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 463, 2, "82", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 464, 2, "83", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 465, 2, "84", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 466, 2, "85", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 467, 2, "86", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 468, 2, "87", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 469, 2, "88", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 470, 2, "89", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 471, 2, "90", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 472, 2, "91", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 473, 2, "92", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 474, 2, "93", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 475, 2, "94", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 476, 2, "95", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 477, 2, "96", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 478, 2, "97", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 479, 2, "98", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 480, 2, "99", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 481, 2, "100", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 482, 2, "101", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 483, 2, "102", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 484, 2, "103", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 485, 2, "104", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 486, 2, "105", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 487, 2, "106", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 488, 2, "107", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 489, 2, "108", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 490, 2, "109", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 491, 2, "110", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 492, 2, "111", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 493, 2, "112", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 494, 2, "113", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 495, 2, "114", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 496, 2, "115", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 497, 2, "116", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 498, 2, "117", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 499, 2, "118", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 500, 2, "119", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 501, 2, "120", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 502, 2, "121", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 503, 2, "122", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 504, 2, "123", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 505, 2, "124", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 506, 2, "125", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 507, 2, "126", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 508, 2, "127", new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350") },
                    { 509, 1, "1", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 510, 1, "2", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 511, 1, "3", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 512, 1, "4", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 513, 1, "5", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 514, 1, "6", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 515, 1, "7", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 516, 1, "8", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 517, 1, "9", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 518, 1, "10", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 519, 1, "11", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 520, 1, "12", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 521, 1, "13", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 522, 1, "14", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 523, 1, "15", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 524, 1, "16", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 525, 1, "17", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 526, 1, "18", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 527, 1, "19", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 528, 1, "20", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 529, 1, "21", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 530, 1, "22", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 531, 1, "23", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 532, 1, "24", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 533, 1, "25", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 534, 1, "26", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 535, 1, "27", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 536, 1, "28", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 537, 1, "29", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 538, 1, "30", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 539, 1, "31", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 540, 1, "32", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 541, 1, "33", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 542, 1, "34", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 543, 1, "35", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 544, 1, "36", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 545, 1, "37", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 546, 1, "38", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 547, 1, "39", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 548, 1, "40", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 549, 1, "41", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 550, 1, "42", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 551, 1, "43", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 552, 1, "44", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 553, 1, "45", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 554, 1, "46", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 555, 1, "47", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 556, 1, "48", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 557, 1, "49", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 558, 1, "50", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 559, 1, "51", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 560, 1, "52", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 561, 1, "53", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 562, 1, "54", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 563, 1, "55", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 564, 1, "56", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 565, 1, "57", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 566, 1, "58", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 567, 1, "59", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 568, 1, "60", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 569, 1, "61", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 570, 1, "62", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 571, 1, "63", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 572, 1, "64", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 573, 2, "65", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 574, 2, "66", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 575, 2, "67", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 576, 2, "68", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 577, 2, "69", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 578, 2, "70", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 579, 2, "71", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 580, 2, "72", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 581, 2, "73", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 582, 2, "74", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 583, 2, "75", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 584, 2, "76", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 585, 2, "77", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 586, 2, "78", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 587, 2, "79", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 588, 2, "80", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 589, 2, "81", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 590, 2, "82", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 591, 2, "83", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 592, 2, "84", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 593, 2, "85", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 594, 2, "86", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 595, 2, "87", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 596, 2, "88", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 597, 2, "89", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 598, 2, "90", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 599, 2, "91", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 600, 2, "92", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 601, 2, "93", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 602, 2, "94", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 603, 2, "95", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 604, 2, "96", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 605, 2, "97", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 606, 2, "98", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 607, 2, "99", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 608, 2, "100", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 609, 2, "101", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 610, 2, "102", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 611, 2, "103", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 612, 2, "104", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 613, 2, "105", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 614, 2, "106", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 615, 2, "107", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 616, 2, "108", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 617, 2, "109", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 618, 2, "110", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 619, 2, "111", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 620, 2, "112", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 621, 2, "113", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 622, 2, "114", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 623, 2, "115", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 624, 2, "116", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 625, 2, "117", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 626, 2, "118", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 627, 2, "119", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 628, 2, "120", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 629, 2, "121", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 630, 2, "122", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 631, 2, "123", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 632, 2, "124", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 633, 2, "125", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 634, 2, "126", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") },
                    { 635, 2, "127", new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "SeatId",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "TrainId",
                keyValue: new Guid("2266d573-e2fe-4d32-b45d-6a9a04d84bcb"));

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "TrainId",
                keyValue: new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"));

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "TrainId",
                keyValue: new Guid("5e6adc1c-5279-47f9-b6e5-dccc00e02350"));

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "TrainId",
                keyValue: new Guid("8be4b93d-68ab-4d5d-aa7a-73264548117b"));

            migrationBuilder.DeleteData(
                table: "Trains",
                keyColumn: "TrainId",
                keyValue: new Guid("98407e8c-f851-4afc-ae75-061d9f563e9c"));

            migrationBuilder.AddColumn<Guid>(
                name: "TrainId1",
                table: "Seats",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Seats_TrainId1",
                table: "Seats",
                column: "TrainId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Trains_TrainId1",
                table: "Seats",
                column: "TrainId1",
                principalTable: "Trains",
                principalColumn: "TrainId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
