using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomationTravelAgency.Migrations
{
    public partial class seedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VehicleNo",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FarePerKm",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "DriverId", "FarePerKm", "SeatingCapacity", "VehicleName", "VehicleNo", "VehicleType" },
                values: new object[,]
                {
                    { 1, "1023", "$0.75", 7, "Traveler's Van", "AB 12 CD 3456", "Van" },
                    { 2, "2045", "$1.00", 5, "Explorer SUV", "XY 45 EF 6789", "SUV" },
                    { 3, "3456", "$0.50", 50, "Comfort Coach", "GH 78 IJ 1234", "Bus" },
                    { 4, "4567", "$0.60", 15, "Journey Shuttle", "KL 90 MN 5678", "Minibus" },
                    { 5, "5678", "$0.80", 8, "Adventure Wagon", "OP 34 QR 9101", "SUV" },
                    { 6, "6789", "$0.90", 4, "Nomad Ride", "ST 56 UV 1213", "Sedan" },
                    { 7, "7890", "$0.45", 40, "Expedition Bus", "WX 78 YZ 1415", "Coach" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.AlterColumn<int>(
                name: "VehicleNo",
                table: "Vehicles",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "FarePerKm",
                table: "Vehicles",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
