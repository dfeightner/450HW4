using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HW4.Migrations
{
    /// <inheritdoc />
    public partial class AddingVehiclesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mileage = table.Column<int>(type: "int", nullable: false),
                    DateReceived = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateSold = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VehicleStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleId);
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "VehicleId", "DateReceived", "DateSold", "Make", "Mileage", "Model", "VIN", "VehicleStatus", "Year" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chevrolet", 20340, "Corvette", "4S3BMHB68B3286050", "Sold", 2016 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chevrolet", 10, "Trax", "8BYBMHB72B3286123", "In-Transit", 2023 },
                    { 3, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ford", 67512, "F-150", "1Y3BJKE68Y45860736", "Available", 2018 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
