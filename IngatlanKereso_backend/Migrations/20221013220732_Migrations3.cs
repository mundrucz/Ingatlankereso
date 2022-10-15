using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IngatlanKereso_backend.Migrations
{
    public partial class Migrations3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estates_Location_locationId",
                table: "Estates");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Estates_locationId",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "WCBathroomOneRoom",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "airConditioning",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "areaSize",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "balcony",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "ceilingHeight",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "condition",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "date",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "description",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "floors",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "garden",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "hasFloors",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "landsize",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "lift",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "locationId",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "numberOfSeens",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "orientation",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "parking",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "pets",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "pictures",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "price",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "rooms",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "sendEmail",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "typeOfHeating",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "view",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "yearBuilt",
                table: "Estates");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "WCBathroomOneRoom",
                table: "Estates",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "airConditioning",
                table: "Estates",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "areaSize",
                table: "Estates",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "balcony",
                table: "Estates",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ceilingHeight",
                table: "Estates",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "condition",
                table: "Estates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "Estates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Estates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "floors",
                table: "Estates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "garden",
                table: "Estates",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "hasFloors",
                table: "Estates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "landsize",
                table: "Estates",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "lift",
                table: "Estates",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "locationId",
                table: "Estates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "numberOfSeens",
                table: "Estates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "orientation",
                table: "Estates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "parking",
                table: "Estates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "pets",
                table: "Estates",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "pictures",
                table: "Estates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "price",
                table: "Estates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "rooms",
                table: "Estates",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "sendEmail",
                table: "Estates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "typeOfHeating",
                table: "Estates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "view",
                table: "Estates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "yearBuilt",
                table: "Estates",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    county = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    district = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    street = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estates_locationId",
                table: "Estates",
                column: "locationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Estates_Location_locationId",
                table: "Estates",
                column: "locationId",
                principalTable: "Location",
                principalColumn: "Id");
        }
    }
}
