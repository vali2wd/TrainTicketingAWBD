using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrainTicketing.Database.Migrations
{
    /// <inheritdoc />
    public partial class VariousSeedsAndDataConfigures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Trains_TrainId",
                table: "Seats");

            migrationBuilder.DropForeignKey(
                name: "FK_TariffRangess_TariffSchemas_TariffSchemaTariffId",
                table: "TariffRangess");

            migrationBuilder.DropIndex(
                name: "IX_TariffRangess_TariffSchemaTariffId",
                table: "TariffRangess");

            migrationBuilder.DropColumn(
                name: "TariffSchemaTariffId",
                table: "TariffRangess");

            migrationBuilder.RenameColumn(
                name: "TariffId",
                table: "TariffSchemas",
                newName: "TariffSchemaId");

            migrationBuilder.AddColumn<int>(
                name: "TariffSchemaId",
                table: "TariffRangess",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<Guid>(
                name: "TrainId",
                table: "Seats",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TrainId1",
                table: "Seats",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "StationId", "StationName" },
                values: new object[,]
                {
                    { new Guid("03905450-41ef-4639-9713-ba663c3773da"), "Eforie Nord" },
                    { new Guid("08b824ab-8ac6-4b24-9872-95ff63b492bf"), "Peris" },
                    { new Guid("0bfcdb5d-163b-4576-b285-f360d6b5bcba"), "Comarnic" },
                    { new Guid("0ed5992e-6dda-407a-8481-5233d26c64e0"), "Crivina" },
                    { new Guid("12279946-5418-4d15-baf9-4daee8566525"), "Videle" },
                    { new Guid("18d9c104-e905-4de8-a4d7-eead496ac5a2"), "Mangalia" },
                    { new Guid("2086698a-e330-439b-ab3d-4dea78c7e688"), "Faurei" },
                    { new Guid("24bb1e5a-4c25-442d-82d3-8ea74348da0f"), "Neptun" },
                    { new Guid("2d1f9718-ce63-4fc9-be0f-fa1d236d5b19"), "Constanta" },
                    { new Guid("33024dc9-bf84-4651-94bd-02a774f43c5b"), "Busteni" },
                    { new Guid("3ef9ccc2-4501-4d00-a5cd-b4f9b94b645d"), "Rosiorii de Vede" },
                    { new Guid("41ff5b07-7ef4-4daf-b2e2-bb9d653d8245"), "Campina" },
                    { new Guid("45ac2f22-2dae-4d32-ad38-34be33fe6a83"), "Eforie Sud" },
                    { new Guid("4806be82-6db7-421c-89b5-d92861bb3fbc"), "Medgidia" },
                    { new Guid("49270139-4185-42e0-9dd9-19e632a4105c"), "Ciulnita" },
                    { new Guid("4d739b70-baaf-4367-9a1a-9d91481e2762"), "Pasarea" },
                    { new Guid("4dd2478d-9065-495c-8696-bd96a842d4a2"), "Fundulea" },
                    { new Guid("542784d4-2297-4a15-b198-81d5f918c12e"), "Otopeni" },
                    { new Guid("55296397-fc75-4d01-ba49-d3c497596d37"), "Vadu Lat" },
                    { new Guid("62c14434-9039-412e-9e36-dcbd7cbbae4f"), "Sinaia" },
                    { new Guid("644540c4-421a-4c79-b1e8-a4c7c8767ac3"), "Costinesti Tabara" },
                    { new Guid("66a74a29-282f-4ff9-b5d6-2f49d3d3536f"), "Brasov" },
                    { new Guid("6ca13ae5-67f1-413b-b5c2-d89efc164c57"), "Ploiesti Vest" },
                    { new Guid("717df56e-fe44-4544-b22e-95398bfb653a"), "Lehliu Gara" },
                    { new Guid("760cf2a1-f42b-4169-8022-497a9826eea4"), "Fetesti" },
                    { new Guid("89825248-a590-4dbb-913a-fc37567c2765"), "Tandarei" },
                    { new Guid("8daeb4c3-de43-4e5a-8e7e-f4645bb03441"), "Azuga" },
                    { new Guid("8f1fd997-1261-450b-912f-8c90650e49d5"), "Bucuresti" },
                    { new Guid("a419a47a-335d-4166-a744-3396142333ce"), "Patinoar" },
                    { new Guid("a831ce86-f068-4753-ba68-c3f9c9443605"), "Predeal" },
                    { new Guid("ac266cf0-3f2c-4aef-baab-2de4d17b2a19"), "Galateni" },
                    { new Guid("bd245552-935b-40a6-bf09-bdba25d09443"), "Fetesti" },
                    { new Guid("c93ed874-9c18-4869-8958-dce572502796"), "Gradinari" },
                    { new Guid("d5d4784b-d3db-474f-aa8a-0508a27753b5"), "Parc Mogosoaia" },
                    { new Guid("dbf75826-aa0d-4431-a0b4-ff1228a0a886"), "Buzau" },
                    { new Guid("f2a36100-4f48-467d-a72b-36f47e0b90de"), "Radoiesti" }
                });

            migrationBuilder.InsertData(
                table: "TariffSchemas",
                columns: new[] { "TariffSchemaId", "TariffSchemaName" },
                values: new object[] { 1, "Standard" });

            migrationBuilder.CreateIndex(
                name: "IX_TariffRangess_TariffSchemaId",
                table: "TariffRangess",
                column: "TariffSchemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_TrainId1",
                table: "Seats",
                column: "TrainId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Trains_TrainId",
                table: "Seats",
                column: "TrainId",
                principalTable: "Trains",
                principalColumn: "TrainId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Trains_TrainId1",
                table: "Seats",
                column: "TrainId1",
                principalTable: "Trains",
                principalColumn: "TrainId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TariffRangess_TariffSchemas_TariffSchemaId",
                table: "TariffRangess",
                column: "TariffSchemaId",
                principalTable: "TariffSchemas",
                principalColumn: "TariffSchemaId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Trains_TrainId",
                table: "Seats");

            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Trains_TrainId1",
                table: "Seats");

            migrationBuilder.DropForeignKey(
                name: "FK_TariffRangess_TariffSchemas_TariffSchemaId",
                table: "TariffRangess");

            migrationBuilder.DropIndex(
                name: "IX_TariffRangess_TariffSchemaId",
                table: "TariffRangess");

            migrationBuilder.DropIndex(
                name: "IX_Seats_TrainId1",
                table: "Seats");

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("03905450-41ef-4639-9713-ba663c3773da"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("08b824ab-8ac6-4b24-9872-95ff63b492bf"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("0bfcdb5d-163b-4576-b285-f360d6b5bcba"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("0ed5992e-6dda-407a-8481-5233d26c64e0"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("12279946-5418-4d15-baf9-4daee8566525"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("18d9c104-e905-4de8-a4d7-eead496ac5a2"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("2086698a-e330-439b-ab3d-4dea78c7e688"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("24bb1e5a-4c25-442d-82d3-8ea74348da0f"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("2d1f9718-ce63-4fc9-be0f-fa1d236d5b19"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("33024dc9-bf84-4651-94bd-02a774f43c5b"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("3ef9ccc2-4501-4d00-a5cd-b4f9b94b645d"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("41ff5b07-7ef4-4daf-b2e2-bb9d653d8245"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("45ac2f22-2dae-4d32-ad38-34be33fe6a83"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("4806be82-6db7-421c-89b5-d92861bb3fbc"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("49270139-4185-42e0-9dd9-19e632a4105c"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("4d739b70-baaf-4367-9a1a-9d91481e2762"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("4dd2478d-9065-495c-8696-bd96a842d4a2"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("542784d4-2297-4a15-b198-81d5f918c12e"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("55296397-fc75-4d01-ba49-d3c497596d37"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("62c14434-9039-412e-9e36-dcbd7cbbae4f"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("644540c4-421a-4c79-b1e8-a4c7c8767ac3"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("66a74a29-282f-4ff9-b5d6-2f49d3d3536f"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("6ca13ae5-67f1-413b-b5c2-d89efc164c57"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("717df56e-fe44-4544-b22e-95398bfb653a"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("760cf2a1-f42b-4169-8022-497a9826eea4"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("89825248-a590-4dbb-913a-fc37567c2765"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("8daeb4c3-de43-4e5a-8e7e-f4645bb03441"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("8f1fd997-1261-450b-912f-8c90650e49d5"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("a419a47a-335d-4166-a744-3396142333ce"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("a831ce86-f068-4753-ba68-c3f9c9443605"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("ac266cf0-3f2c-4aef-baab-2de4d17b2a19"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("bd245552-935b-40a6-bf09-bdba25d09443"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("c93ed874-9c18-4869-8958-dce572502796"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("d5d4784b-d3db-474f-aa8a-0508a27753b5"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("dbf75826-aa0d-4431-a0b4-ff1228a0a886"));

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "StationId",
                keyValue: new Guid("f2a36100-4f48-467d-a72b-36f47e0b90de"));

            migrationBuilder.DeleteData(
                table: "TariffSchemas",
                keyColumn: "TariffSchemaId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "TariffSchemaId",
                table: "TariffRangess");

            migrationBuilder.DropColumn(
                name: "TrainId1",
                table: "Seats");

            migrationBuilder.RenameColumn(
                name: "TariffSchemaId",
                table: "TariffSchemas",
                newName: "TariffId");

            migrationBuilder.AddColumn<int>(
                name: "TariffSchemaTariffId",
                table: "TariffRangess",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "TrainId",
                table: "Seats",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_TariffRangess_TariffSchemaTariffId",
                table: "TariffRangess",
                column: "TariffSchemaTariffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Trains_TrainId",
                table: "Seats",
                column: "TrainId",
                principalTable: "Trains",
                principalColumn: "TrainId");

            migrationBuilder.AddForeignKey(
                name: "FK_TariffRangess_TariffSchemas_TariffSchemaTariffId",
                table: "TariffRangess",
                column: "TariffSchemaTariffId",
                principalTable: "TariffSchemas",
                principalColumn: "TariffId");
        }
    }
}
