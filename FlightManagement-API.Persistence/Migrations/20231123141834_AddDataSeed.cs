using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlightManagement_API.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "status",
                table: "Flights",
                newName: "Status");

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "BusinessClassSeats", "Created", "CreatedBy", "EconomyClassSeats", "Inactivated", "InactivatedBy", "LastMaintenanceDate", "Manufacturer", "Model", "Modified", "ModifiedBy", "Range", "SeatCapacity", "StatusId", "YearOfManufacture" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5429), "admin", 0, null, "", new DateOnly(1, 1, 1), "Boeing", "777", null, "", 0.0, 300, 1, new DateOnly(1, 1, 1) },
                    { 2, 0, new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5437), "admin", 0, null, "", new DateOnly(1, 1, 1), "Airbus", "A380", null, "", 0.0, 500, 1, new DateOnly(1, 1, 1) }
                });

            migrationBuilder.InsertData(
                table: "Airlines",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "LogoUrl", "Modified", "ModifiedBy", "Name", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(4862), "admin", null, "", "url_to_logo_american", null, "", "American Airlines", 1 },
                    { 2, new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(4953), "admin", null, "", "url_to_logo_lufthansa", null, "", "Lufthansa", 1 }
                });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "Created", "CreatedBy", "IataCode", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "StatusId", "City", "Country", "State", "Street", "ZipCode" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5207), "admin", "LAX", null, "", null, "", "Los Angeles International Airport", 1, "Los Angeles", "USA", "CA", "1 World Way", "90045" },
                    { 2, new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5212), "admin", "FRA", null, "", null, "", "Frankfurt Airport", 1, "Frankfurt", "Germany", "Hesse", "60547 Frankfurt", "60547" }
                });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "Id", "Created", "CreatedBy", "Email", "FirstName", "Inactivated", "InactivatedBy", "LastName", "Modified", "ModifiedBy", "PhoneNumber", "StatusId", "City", "Country", "State", "Street", "ZipCode" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5545), "admin", "johndoe@example.com", "John", null, "", "Doe", null, "", "123456789", 1, "New York", "USA", "NY", "123 Broadway", "10007" },
                    { 2, new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5549), "admin", "janesmith@example.com", "Jane", null, "", "Smith", null, "", "987654321", 1, "Berlin", "Germany", "Berlin", "Alexanderplatz 1", "10178" }
                });

            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "Id", "AircraftId", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "StatusId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5735), "admin", null, "", null, "", "Wi-Fi", 1 },
                    { 2, 1, new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5738), "admin", null, "", null, "", "Extra Legroom", 1 }
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "AircraftId", "AirlineId", "ArrivalAirportId", "ArrivalTime", "Created", "CreatedBy", "DepartureAirportId", "DepartureTime", "FlightNumber", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Status", "StatusId" },
                values: new object[,]
                {
                    { 1, 1, 1, 2, new DateTime(2023, 11, 24, 2, 18, 34, 13, DateTimeKind.Local).AddTicks(5469), new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5471), "admin", 1, new DateTime(2023, 11, 23, 18, 18, 34, 13, DateTimeKind.Local).AddTicks(5466), "AA100", null, "", null, "", "Active", 1 },
                    { 2, 2, 2, 1, new DateTime(2023, 11, 24, 11, 18, 34, 13, DateTimeKind.Local).AddTicks(5477), new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5479), "admin", 2, new DateTime(2023, 11, 24, 3, 18, 34, 13, DateTimeKind.Local).AddTicks(5475), "LH205", null, "", null, "", "Active", 1 }
                });

            migrationBuilder.InsertData(
                table: "Luggages",
                columns: new[] { "Id", "Created", "CreatedBy", "Dimensions", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "PassengerId", "Status", "StatusId", "Type", "Weight" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5766), "admin", "22x14x9 inches", null, "", null, "", 1, "Checked", 1, "Carry-on", 15.5 },
                    { 2, new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5770), "admin", "24x16x10 inches", null, "", null, "", 2, "Checked", 1, "Checked", 20.0 }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "Created", "CreatedBy", "FlightId", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "PassengerId", "Price", "ReservationDate", "Status", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5706), "admin", 1, null, "", null, "", 1, 500.0, new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5701), "Confirmed", 1 },
                    { 2, new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5712), "admin", 2, null, "", null, "", 2, 750.0, new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5710), "Confirmed", 1 }
                });

            migrationBuilder.InsertData(
                table: "FlightDetails",
                columns: new[] { "Id", "Aerobridge", "BaggageCarousel", "BoardingStatus", "CheckInCounter", "Created", "CreatedBy", "FlightDistance", "Gate", "GateTime", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Stand", "StatusId", "Terminal" },
                values: new object[,]
                {
                    { 1, true, "Carousel 5", "On Time", 22, new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5510), "admin", 2500.0, "G5", new DateTime(2023, 11, 23, 17, 48, 34, 13, DateTimeKind.Local).AddTicks(5507), null, "", null, "", "Stand 3A", 1, "Terminal 1" },
                    { 2, false, "Carousel 3", "Delayed", 18, new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5515), "admin", 3200.0, "G10", new DateTime(2023, 11, 24, 2, 48, 34, 13, DateTimeKind.Local).AddTicks(5513), null, "", null, "", "Stand 4B", 1, "Terminal 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Luggages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Luggages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Flights",
                newName: "status");
        }
    }
}
