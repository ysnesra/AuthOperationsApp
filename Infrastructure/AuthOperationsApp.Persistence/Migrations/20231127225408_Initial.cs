using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AuthOperationsApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FullName", "Password", "Phone", "UserName" },
                values: new object[,]
                {
                    { new Guid("72305372-470f-4b15-8876-f61b72691841"), "esra@gmail.com", "Esra Yaşın", "Esra.1", "05331545547", "esra" },
                    { new Guid("73305372-470f-4b15-8876-f61b72691843"), "mehmet@gmail.com", "Mehmet Kutlu", "Mehmet.1", "05551545547", "mehmet" },
                    { new Guid("74605372-470f-4b15-8876-f61b72691846"), "aysel@gmail.com", "Aysel Aydınlık", "Aysel.1", "05351545343", "aysel" },
                    { new Guid("75005372-470f-4b15-8876-f61b72691849"), "melek@gmail.com", "Melek Mutlu", "Melek.1", "05651547343", "melek" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "RoleGroups");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserGroups");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
