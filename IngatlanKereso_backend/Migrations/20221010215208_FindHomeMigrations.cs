using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IngatlanKereso_backend.Migrations
{
    public partial class FindHomeMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    county = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    district = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    street = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sendEmail = table.Column<int>(type: "int", nullable: true),
                    numberOfSeens = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    locationId = table.Column<int>(type: "int", nullable: true),
                    areaSize = table.Column<double>(type: "float", nullable: false),
                    landsize = table.Column<double>(type: "float", nullable: true),
                    condition = table.Column<int>(type: "int", nullable: true),
                    ceilingHeight = table.Column<double>(type: "float", nullable: true),
                    rooms = table.Column<double>(type: "float", nullable: false),
                    floors = table.Column<int>(type: "int", nullable: true),
                    hasFloors = table.Column<int>(type: "int", nullable: true),
                    lift = table.Column<bool>(type: "bit", nullable: true),
                    garden = table.Column<double>(type: "float", nullable: true),
                    parking = table.Column<int>(type: "int", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pets = table.Column<bool>(type: "bit", nullable: true),
                    balcony = table.Column<bool>(type: "bit", nullable: true),
                    pictures = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    yearBuilt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    view = table.Column<int>(type: "int", nullable: true),
                    WCBathroomOneRoom = table.Column<bool>(type: "bit", nullable: true),
                    airConditioning = table.Column<bool>(type: "bit", nullable: true),
                    typeOfHeating = table.Column<int>(type: "int", nullable: true),
                    orientation = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estates_Location_locationId",
                        column: x => x.locationId,
                        principalTable: "Location",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Estates_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estates_locationId",
                table: "Estates",
                column: "locationId");

            migrationBuilder.CreateIndex(
                name: "IX_Estates_UserId",
                table: "Estates",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estates");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
