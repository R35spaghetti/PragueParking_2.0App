using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PragueParking_2._0.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Garage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberPlate = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CheckInTimeStamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ParkingSpot = table.Column<int>(type: "int", nullable: false),
                    VehicleType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garage", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Garage_NumberPlate",
                table: "Garage",
                column: "NumberPlate",
                unique: true,
                filter: "[NumberPlate] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Garage");
        }
    }
}
