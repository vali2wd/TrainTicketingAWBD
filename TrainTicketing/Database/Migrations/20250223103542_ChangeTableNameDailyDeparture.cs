using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrainTicketing.Database.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTableNameDailyDeparture : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c3325e50-9ba5-4a3a-bd49-ef5d0c6f950b", "2ea2314c-9bd4-4b84-8268-18f1f385fce8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8a40f9a5-74e8-448a-8b4c-d20e77bb2f36", "968a7dae-9e35-4ec1-a0c5-6dfb74bccefd" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a40f9a5-74e8-448a-8b4c-d20e77bb2f36");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3325e50-9ba5-4a3a-bd49-ef5d0c6f950b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ea2314c-9bd4-4b84-8268-18f1f385fce8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "968a7dae-9e35-4ec1-a0c5-6dfb74bccefd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "42020344-0357-4eaa-957d-70a4d3ad7976", null, "Client", "CLIENT" },
                    { "d9a4c4f9-8621-4d86-867e-43969db6c4f0", null, "Worker", "WORKER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4c7a3dae-782a-43f0-86b5-c5d88cdbd728", 0, "e9e9642d-58a1-4c98-8b8c-aeaf39cac838", "client@email.ro", true, false, null, "CLIENT@EMAIL.RO", "CLIENT@EMAIL.RO", "AQAAAAIAAYagAAAAED+TYhnleEJsetUiqGgDRmbPbAUvx6x6Jko+BEImVI81+z6YTpe9amg5fR67aTzdvw==", null, false, "70c5a037-1766-454f-ae4f-83808aaac405", false, "client@email.ro" },
                    { "67c5bdec-8e8b-4f5a-a35d-e73dd7c19dc3", 0, "6437d547-7e77-46b8-ae4f-08f5f1600b9e", "worker@email.ro", true, false, null, "WORKER@EMAIL.RO", "WORKER@EMAIL.RO", "AQAAAAIAAYagAAAAEIXCQqbRIQwCCfbm7AL8xq04wTHlyYi/sMGKpNV2MU394RgPlyvSCngotMCk/dKHIA==", null, false, "3b9de005-8aec-4e8e-a891-957925b6c828", false, "worker@email.ro" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "42020344-0357-4eaa-957d-70a4d3ad7976", "4c7a3dae-782a-43f0-86b5-c5d88cdbd728" },
                    { "d9a4c4f9-8621-4d86-867e-43969db6c4f0", "67c5bdec-8e8b-4f5a-a35d-e73dd7c19dc3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "42020344-0357-4eaa-957d-70a4d3ad7976", "4c7a3dae-782a-43f0-86b5-c5d88cdbd728" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d9a4c4f9-8621-4d86-867e-43969db6c4f0", "67c5bdec-8e8b-4f5a-a35d-e73dd7c19dc3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42020344-0357-4eaa-957d-70a4d3ad7976");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9a4c4f9-8621-4d86-867e-43969db6c4f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c7a3dae-782a-43f0-86b5-c5d88cdbd728");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67c5bdec-8e8b-4f5a-a35d-e73dd7c19dc3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8a40f9a5-74e8-448a-8b4c-d20e77bb2f36", null, "Client", "CLIENT" },
                    { "c3325e50-9ba5-4a3a-bd49-ef5d0c6f950b", null, "Worker", "WORKER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2ea2314c-9bd4-4b84-8268-18f1f385fce8", 0, "962b3164-3217-4c14-9b0e-e5ce504bd899", "worker@email.ro", true, false, null, "WORKER@EMAIL.RO", "WORKER@EMAIL.RO", "AQAAAAIAAYagAAAAEOo6f/FKShbZ748/ZaaNh6FxNutKdfxH5PBq78QBldHn8ybRjqYV4mdRpdCbaDzwdg==", null, false, "a58c25bb-a788-4faf-aafa-c45580ce78d5", false, "worker@email.ro" },
                    { "968a7dae-9e35-4ec1-a0c5-6dfb74bccefd", 0, "84ab08aa-4841-46b0-a752-df080e4c8b10", "client@email.ro", true, false, null, "CLIENT@EMAIL.RO", "CLIENT@EMAIL.RO", "AQAAAAIAAYagAAAAEFpm0GUH3BUzOfrzsx7WrKvx0YyLyROv3bcAHNLYDlSulQknNTYFfUO7hCbRLerrtQ==", null, false, "b4a324f5-b4a2-482a-8f46-6f0176920e0b", false, "client@email.ro" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c3325e50-9ba5-4a3a-bd49-ef5d0c6f950b", "2ea2314c-9bd4-4b84-8268-18f1f385fce8" },
                    { "8a40f9a5-74e8-448a-8b4c-d20e77bb2f36", "968a7dae-9e35-4ec1-a0c5-6dfb74bccefd" }
                });
        }
    }
}
