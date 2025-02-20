using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrainTicketing.Database.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stations",
                columns: table => new
                {
                    StationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StationName = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations", x => x.StationId);
                });

            migrationBuilder.CreateTable(
                name: "TariffSchemas",
                columns: table => new
                {
                    TariffSchemaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TariffSchemaName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TariffSchemas", x => x.TariffSchemaId);
                });

            migrationBuilder.CreateTable(
                name: "Trains",
                columns: table => new
                {
                    TrainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrainName = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    TrainType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trains", x => x.TrainId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    AnnouncementId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.AnnouncementId);
                    table.ForeignKey(
                        name: "FK_Announcements_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    RouteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RouteName = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    MainTerminalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TariffSchemaId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalDistance = table.Column<decimal>(type: "decimal(8,4)", precision: 8, scale: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.RouteId);
                    table.ForeignKey(
                        name: "FK_Routes_Stations_MainTerminalId",
                        column: x => x.MainTerminalId,
                        principalTable: "Stations",
                        principalColumn: "StationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Routes_TariffSchemas_TariffSchemaId",
                        column: x => x.TariffSchemaId,
                        principalTable: "TariffSchemas",
                        principalColumn: "TariffSchemaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TariffRangess",
                columns: table => new
                {
                    TariffRangeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartKm = table.Column<decimal>(type: "decimal(8,4)", precision: 8, scale: 4, nullable: false),
                    EndKm = table.Column<decimal>(type: "decimal(8,4)", precision: 8, scale: 4, nullable: true),
                    PricePerKm = table.Column<decimal>(type: "decimal(8,4)", precision: 8, scale: 4, nullable: false),
                    TariffSchemaId = table.Column<int>(type: "int", nullable: false),
                    SeatClass = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TariffRangess", x => x.TariffRangeId);
                    table.ForeignKey(
                        name: "FK_TariffRangess_TariffSchemas_TariffSchemaId",
                        column: x => x.TariffSchemaId,
                        principalTable: "TariffSchemas",
                        principalColumn: "TariffSchemaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    SeatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeatCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    TrainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SeatClass = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.SeatId);
                    table.ForeignKey(
                        name: "FK_Seats_Trains_TrainId",
                        column: x => x.TrainId,
                        principalTable: "Trains",
                        principalColumn: "TrainId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DepartureSchedules",
                columns: table => new
                {
                    DepartureScheduleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RouteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OutboundMain = table.Column<bool>(type: "bit", nullable: false),
                    TrainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartureSchedules", x => x.DepartureScheduleId);
                    table.ForeignKey(
                        name: "FK_DepartureSchedules_Routes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Routes",
                        principalColumn: "RouteId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DepartureSchedules_Trains_TrainId",
                        column: x => x.TrainId,
                        principalTable: "Trains",
                        principalColumn: "TrainId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RouteDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RouteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderOfStationFromMain = table.Column<int>(type: "int", nullable: false),
                    DistanceFromMain = table.Column<decimal>(type: "decimal(8,4)", precision: 8, scale: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RouteDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RouteDetails_Routes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Routes",
                        principalColumn: "RouteId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RouteDetails_Stations_StationId",
                        column: x => x.StationId,
                        principalTable: "Stations",
                        principalColumn: "StationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DailyDepartures",
                columns: table => new
                {
                    DailyDepartureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfDeparture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartureScheduleId = table.Column<int>(type: "int", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VersionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyDepartures", x => x.DailyDepartureId);
                    table.ForeignKey(
                        name: "FK_DailyDepartures_DepartureSchedules_DepartureScheduleId",
                        column: x => x.DepartureScheduleId,
                        principalTable: "DepartureSchedules",
                        principalColumn: "DepartureScheduleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DepartureDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartureId = table.Column<int>(type: "int", nullable: false),
                    RouteDetailId = table.Column<int>(type: "int", nullable: false),
                    DepatureTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartureDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepartureDetails_DepartureSchedules_DepartureId",
                        column: x => x.DepartureId,
                        principalTable: "DepartureSchedules",
                        principalColumn: "DepartureScheduleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartureDetails_RouteDetails_RouteDetailId",
                        column: x => x.RouteDetailId,
                        principalTable: "RouteDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SeatId = table.Column<int>(type: "int", nullable: false),
                    DepartureStationRouteDetailId = table.Column<int>(type: "int", nullable: true),
                    ArrivalStationRouteDetailId = table.Column<int>(type: "int", nullable: true),
                    DailyDepartureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_DailyDepartures_DailyDepartureId",
                        column: x => x.DailyDepartureId,
                        principalTable: "DailyDepartures",
                        principalColumn: "DailyDepartureId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_RouteDetails_ArrivalStationRouteDetailId",
                        column: x => x.ArrivalStationRouteDetailId,
                        principalTable: "RouteDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_RouteDetails_DepartureStationRouteDetailId",
                        column: x => x.DepartureStationRouteDetailId,
                        principalTable: "RouteDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_Seats_SeatId",
                        column: x => x.SeatId,
                        principalTable: "Seats",
                        principalColumn: "SeatId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b51b257d-c584-41c6-93c1-7fcee36a8aa0", null, "Client", "CLIENT" },
                    { "c2d7e6b5-5143-4ca9-9ecf-26d9c7d25a93", null, "Worker", "WORKER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3a7bceef-390d-497b-a81f-b3719470daae", 0, "6b8f3668-3ace-49c4-ade0-d9dcf04c895e", "worker@email.ro", true, false, null, "WORKER@EMAIL.RO", "WORKER@EMAIL.RO", "AQAAAAIAAYagAAAAEGAGDN3fdXhAIWzUNs/XwyDDxxnWgdIzWoflRHFcvUvj8ykB4xDGJJ0CCzC7zLg9Iw==", null, false, "898b3e64-eda4-4bf2-b42a-0dddea441675", false, "worker@email.ro" },
                    { "4affb04a-c718-4e07-8041-a55eb8b5defc", 0, "4c8ae971-209a-4910-a592-692205202486", "client@email.ro", true, false, null, "CLIENT@EMAIL.RO", "CLIENT@EMAIL.RO", "AQAAAAIAAYagAAAAELUk1M1fx9vuyJ3LdR1NkS1KhreqS2fvF63I4olQ4W9BUaEKFhTdA/T5KIdseALGZg==", null, false, "71bef33a-1dc1-4a7d-8d7d-9883a9a491d1", false, "client@email.ro" }
                });

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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c2d7e6b5-5143-4ca9-9ecf-26d9c7d25a93", "3a7bceef-390d-497b-a81f-b3719470daae" },
                    { "b51b257d-c584-41c6-93c1-7fcee36a8aa0", "4affb04a-c718-4e07-8041-a55eb8b5defc" }
                });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "RouteId", "ImagePath", "MainTerminalId", "RouteName", "TariffSchemaId", "TotalDistance" },
                values: new object[] { new Guid("3dba6d64-acae-4cee-acff-630ef2b81d2a"), "https://trainticketing.blob.core.windows.net/trainticketingimages/ruta_Bucuresti-Brasov.png", new Guid("8f1fd997-1261-450b-912f-8c90650e49d5"), "Bucuresti-Brasov", 1, 169.0m });

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

            migrationBuilder.InsertData(
                table: "DepartureSchedules",
                columns: new[] { "DepartureScheduleId", "OutboundMain", "RouteId", "TrainId" },
                values: new object[,]
                {
                    { 1, true, new Guid("3dba6d64-acae-4cee-acff-630ef2b81d2a"), new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 2, false, new Guid("3dba6d64-acae-4cee-acff-630ef2b81d2a"), new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 3, true, new Guid("3dba6d64-acae-4cee-acff-630ef2b81d2a"), new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") },
                    { 4, false, new Guid("3dba6d64-acae-4cee-acff-630ef2b81d2a"), new Guid("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93") }
                });

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

            migrationBuilder.InsertData(
                table: "DailyDepartures",
                columns: new[] { "DailyDepartureId", "DateOfDeparture", "DepartureScheduleId", "ModifyDate", "VersionId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0 },
                    { 2, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0 },
                    { 3, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 0 },
                    { 4, new DateTime(2025, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, 0 },
                    { 5, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0 },
                    { 6, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0 },
                    { 7, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 0 },
                    { 8, new DateTime(2025, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, 0 },
                    { 9, new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 0 },
                    { 10, new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 0 },
                    { 11, new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, null, 0 },
                    { 12, new DateTime(2025, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "DepartureDetails",
                columns: new[] { "Id", "DepartureId", "DepatureTime", "RouteDetailId" },
                values: new object[,]
                {
                    { 1, 1, new TimeSpan(0, 7, 0, 0, 0), 1 },
                    { 2, 1, new TimeSpan(0, 7, 20, 0, 0), 2 },
                    { 3, 1, new TimeSpan(0, 7, 30, 0, 0), 3 },
                    { 4, 1, new TimeSpan(0, 7, 42, 0, 0), 4 },
                    { 5, 1, new TimeSpan(0, 8, 6, 0, 0), 5 },
                    { 6, 1, new TimeSpan(0, 8, 18, 0, 0), 6 },
                    { 7, 1, new TimeSpan(0, 8, 35, 0, 0), 7 },
                    { 8, 1, new TimeSpan(0, 8, 44, 0, 0), 8 },
                    { 9, 1, new TimeSpan(0, 8, 50, 0, 0), 9 },
                    { 10, 1, new TimeSpan(0, 9, 0, 0, 0), 10 },
                    { 11, 1, new TimeSpan(0, 9, 33, 0, 0), 11 },
                    { 12, 2, new TimeSpan(0, 12, 39, 0, 0), 1 },
                    { 13, 2, new TimeSpan(0, 12, 30, 0, 0), 2 },
                    { 14, 2, new TimeSpan(0, 12, 20, 0, 0), 3 },
                    { 15, 2, new TimeSpan(0, 12, 0, 0, 0), 4 },
                    { 16, 2, new TimeSpan(0, 11, 33, 0, 0), 5 },
                    { 17, 2, new TimeSpan(0, 11, 18, 0, 0), 6 },
                    { 18, 2, new TimeSpan(0, 11, 3, 0, 0), 7 },
                    { 19, 2, new TimeSpan(0, 10, 53, 0, 0), 8 },
                    { 20, 2, new TimeSpan(0, 10, 46, 0, 0), 9 },
                    { 21, 2, new TimeSpan(0, 10, 36, 0, 0), 10 },
                    { 22, 2, new TimeSpan(0, 9, 56, 0, 0), 11 },
                    { 23, 3, new TimeSpan(0, 15, 0, 0, 0), 1 },
                    { 24, 3, new TimeSpan(0, 15, 20, 0, 0), 2 },
                    { 25, 3, new TimeSpan(0, 15, 30, 0, 0), 3 },
                    { 26, 3, new TimeSpan(0, 15, 42, 0, 0), 4 },
                    { 27, 3, new TimeSpan(0, 16, 6, 0, 0), 5 },
                    { 28, 3, new TimeSpan(0, 16, 18, 0, 0), 6 },
                    { 29, 3, new TimeSpan(0, 16, 35, 0, 0), 7 },
                    { 30, 3, new TimeSpan(0, 16, 44, 0, 0), 8 },
                    { 31, 3, new TimeSpan(0, 16, 50, 0, 0), 9 },
                    { 32, 3, new TimeSpan(0, 17, 0, 0, 0), 10 },
                    { 33, 3, new TimeSpan(0, 17, 33, 0, 0), 11 },
                    { 34, 4, new TimeSpan(0, 20, 39, 0, 0), 1 },
                    { 35, 4, new TimeSpan(0, 20, 30, 0, 0), 2 },
                    { 36, 4, new TimeSpan(0, 20, 20, 0, 0), 3 },
                    { 37, 4, new TimeSpan(0, 20, 0, 0, 0), 4 },
                    { 38, 4, new TimeSpan(0, 19, 33, 0, 0), 5 },
                    { 39, 4, new TimeSpan(0, 19, 18, 0, 0), 6 },
                    { 40, 4, new TimeSpan(0, 19, 3, 0, 0), 7 },
                    { 41, 4, new TimeSpan(0, 18, 53, 0, 0), 8 },
                    { 42, 4, new TimeSpan(0, 18, 46, 0, 0), 9 },
                    { 43, 4, new TimeSpan(0, 18, 36, 0, 0), 10 },
                    { 44, 4, new TimeSpan(0, 17, 56, 0, 0), 11 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_CreatedById",
                table: "Announcements",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DailyDepartures_DepartureScheduleId",
                table: "DailyDepartures",
                column: "DepartureScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartureDetails_DepartureId",
                table: "DepartureDetails",
                column: "DepartureId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartureDetails_RouteDetailId",
                table: "DepartureDetails",
                column: "RouteDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartureSchedules_RouteId",
                table: "DepartureSchedules",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartureSchedules_TrainId",
                table: "DepartureSchedules",
                column: "TrainId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ArrivalStationRouteDetailId",
                table: "Reservations",
                column: "ArrivalStationRouteDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_DailyDepartureId",
                table: "Reservations",
                column: "DailyDepartureId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_DepartureStationRouteDetailId",
                table: "Reservations",
                column: "DepartureStationRouteDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_SeatId",
                table: "Reservations",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RouteDetails_RouteId",
                table: "RouteDetails",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_RouteDetails_StationId",
                table: "RouteDetails",
                column: "StationId");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_MainTerminalId",
                table: "Routes",
                column: "MainTerminalId");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_TariffSchemaId",
                table: "Routes",
                column: "TariffSchemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_TrainId",
                table: "Seats",
                column: "TrainId");

            migrationBuilder.CreateIndex(
                name: "IX_TariffRangess_TariffSchemaId",
                table: "TariffRangess",
                column: "TariffSchemaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DepartureDetails");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "TariffRangess");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "DailyDepartures");

            migrationBuilder.DropTable(
                name: "RouteDetails");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "DepartureSchedules");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Trains");

            migrationBuilder.DropTable(
                name: "Stations");

            migrationBuilder.DropTable(
                name: "TariffSchemas");
        }
    }
}
