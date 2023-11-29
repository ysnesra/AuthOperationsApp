using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuthOperationsApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("27105372-470f-4b15-8876-f61b72691841"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("52005372-470f-4b15-8876-f61b72691841"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("53005372-470f-4b15-8876-f61b72691842"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("54905372-470f-4b15-8876-f61b72691843"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("55805372-470f-4b15-8876-f61b72691844"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("56005372-470f-4b15-8876-f61b72691842"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("22905372-470f-4b15-8876-f61b72691841"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("23905372-470f-4b15-8876-f61b72691842"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("24905372-470f-4b15-8876-f61b72691843"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("25905372-470f-4b15-8876-f61b72691844"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("26005372-470f-4b15-8876-f61b72691842"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("27105372-470f-4b15-8876-f61b72691841"));

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("02c551e4-d201-41ce-ba11-98c218d91bcf"), "Eğitim destek grubu" },
                    { new Guid("03be5560-b263-43d2-ab28-0206b58098f1"), "Raporlama grubu" },
                    { new Guid("2538688c-3339-428c-8197-dab8e3d8842b"), "Mağaza müdürleri grubu" },
                    { new Guid("449f4f14-ffb6-4ff7-ab32-93d0fb430602"), "IT destek grubu" },
                    { new Guid("73335711-f124-418c-95bf-107bdfca4d90"), "IK çalışanları grubu" },
                    { new Guid("a00eb1f5-a62f-4be6-ad58-9d910f6f2948"), "Satış müdürleri grubu" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("23e2e4b5-415f-4087-afea-4c36bfa02dec"), "Wallboard yetkisi" },
                    { new Guid("5c9c718f-61fa-4d5b-8924-7d5a8e559df5"), "İlanlarım yetkisi" },
                    { new Guid("679dddf8-37e9-4012-9f8b-e0c5ebb747b8"), "Satışlarım sayfasına girme yetkisi" },
                    { new Guid("8da091a4-959f-4a89-aca9-fd50d6c4a836"), "Taleplerim yetkisi" },
                    { new Guid("9e70e434-e56f-4679-8d80-f471c914ddb4"), "Taleplerim sayfasına girme yetkisi" },
                    { new Guid("c2d99a10-0427-4afc-8300-246b985128ec"), "Dashboard yetkisi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("02c551e4-d201-41ce-ba11-98c218d91bcf"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("03be5560-b263-43d2-ab28-0206b58098f1"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("2538688c-3339-428c-8197-dab8e3d8842b"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("449f4f14-ffb6-4ff7-ab32-93d0fb430602"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("73335711-f124-418c-95bf-107bdfca4d90"));

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: new Guid("a00eb1f5-a62f-4be6-ad58-9d910f6f2948"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("23e2e4b5-415f-4087-afea-4c36bfa02dec"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5c9c718f-61fa-4d5b-8924-7d5a8e559df5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("679dddf8-37e9-4012-9f8b-e0c5ebb747b8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8da091a4-959f-4a89-aca9-fd50d6c4a836"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e70e434-e56f-4679-8d80-f471c914ddb4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c2d99a10-0427-4afc-8300-246b985128ec"));

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("27105372-470f-4b15-8876-f61b72691841"), "Eğitim destek grubu" },
                    { new Guid("52005372-470f-4b15-8876-f61b72691841"), "Mağaza müdürleri grubu" },
                    { new Guid("53005372-470f-4b15-8876-f61b72691842"), "Satış müdürleri grubu" },
                    { new Guid("54905372-470f-4b15-8876-f61b72691843"), "IK çalışanları grubu" },
                    { new Guid("55805372-470f-4b15-8876-f61b72691844"), "Raporlama grubu" },
                    { new Guid("56005372-470f-4b15-8876-f61b72691842"), "IT destek grubu" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("22905372-470f-4b15-8876-f61b72691841"), "Taleplerim sayfasına girme yetki" },
                    { new Guid("23905372-470f-4b15-8876-f61b72691842"), "Satışlarım sayfasına girme yetkisi" },
                    { new Guid("24905372-470f-4b15-8876-f61b72691843"), "Dashboard yetkisi" },
                    { new Guid("25905372-470f-4b15-8876-f61b72691844"), "Wallboard yetkisi" },
                    { new Guid("26005372-470f-4b15-8876-f61b72691842"), "Wallboard yetkisi" },
                    { new Guid("27105372-470f-4b15-8876-f61b72691841"), "İlanlarım yetkisi" }
                });
        }
    }
}
