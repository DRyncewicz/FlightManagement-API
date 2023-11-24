using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlightManagement_API.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDataSeedSecond : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Airlines",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "LogoUrl", "Modified", "ModifiedBy", "Name", "StatusId" },
                values: new object[,]
                {
                    { 11, new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(8263), "admin", null, "", "url_to_logo_american", null, "", "American Airlines", 1 },
                    { 12, new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(8461), "admin", null, "", "url_to_logo_lufthansa", null, "", "Lufthansa", 1 }
                });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "Created", "CreatedBy", "IataCode", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "StatusId", "City", "Country", "State", "Street", "ZipCode" },
                values: new object[,]
                {
                    { 11, new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(8826), "admin", "LAX", null, "", null, "", "Los Angeles International Airport", 1, "Los Angeles", "USA", "CA", "1 World Way", "90045" },
                    { 12, new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(8830), "admin", "FRA", null, "", null, "", "Frankfurt Airport", 1, "Frankfurt", "Germany", "Hesse", "60547 Frankfurt", "60547" }
                });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "Id", "Created", "CreatedBy", "Email", "FirstName", "Inactivated", "InactivatedBy", "LastName", "Modified", "ModifiedBy", "PhoneNumber", "StatusId", "City", "Country", "State", "Street", "ZipCode" },
                values: new object[,]
                {
                    { 11, new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9243), "admin", "johndoe@example.com", "John", null, "", "Doe", null, "", "123456789", 1, "New York", "USA", "NY", "123 Broadway", "10007" },
                    { 12, new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9248), "admin", "janesmith@example.com", "Jane", null, "", "Smith", null, "", "987654321", 1, "Berlin", "Germany", "Berlin", "Alexanderplatz 1", "10178" }
                });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "AirlineId", "BusinessClassSeats", "Created", "CreatedBy", "EconomyClassSeats", "Inactivated", "InactivatedBy", "LastMaintenanceDate", "Manufacturer", "Model", "Modified", "ModifiedBy", "Range", "SeatCapacity", "StatusId", "YearOfManufacture" },
                values: new object[,]
                {
                    { 11, 11, 100, new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9048), "admin", 200, null, "", new DateOnly(1, 1, 1), "Boeing", "777", null, "", 10820.0, 300, 1, new DateOnly(1, 1, 1) },
                    { 12, 11, 160, new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9057), "admin", 340, null, "", new DateOnly(1, 1, 1), "Airbus", "A380", null, "", 15200.0, 500, 1, new DateOnly(1, 1, 1) }
                });

            migrationBuilder.InsertData(
                table: "Luggages",
                columns: new[] { "Id", "Created", "CreatedBy", "Dimensions", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "PassengerId", "Status", "StatusId", "Type", "Weight" },
                values: new object[,]
                {
                    { 11, new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9493), "admin", "22x14x9 inches", null, "", null, "", 11, "Checked", 1, "Carry-on", 15.5 },
                    { 12, new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9497), "admin", "24x16x10 inches", null, "", null, "", 12, "Checked", 1, "Checked", 20.0 }
                });

            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "Id", "AircraftId", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "StatusId" },
                values: new object[,]
                {
                    { 11, 11, new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9463), "admin", null, "", null, "", "Wi-Fi", 1 },
                    { 12, 11, new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9466), "admin", null, "", null, "", "Extra Legroom", 1 }
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "AircraftId", "AirlineId", "ArrivalAirportId", "ArrivalTime", "Created", "CreatedBy", "DepartureAirportId", "DepartureTime", "FlightNumber", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Status", "StatusId" },
                values: new object[,]
                {
                    { 11, 11, 11, 12, new DateTime(2023, 11, 24, 23, 21, 35, 708, DateTimeKind.Local).AddTicks(9094), new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9096), "admin", 11, new DateTime(2023, 11, 24, 15, 21, 35, 708, DateTimeKind.Local).AddTicks(9090), "AA100", null, "", null, "", "Active", 1 },
                    { 12, 12, 12, 11, new DateTime(2023, 11, 25, 8, 21, 35, 708, DateTimeKind.Local).AddTicks(9102), new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9104), "admin", 12, new DateTime(2023, 11, 25, 0, 21, 35, 708, DateTimeKind.Local).AddTicks(9100), "LH205", null, "", null, "", "Active", 1 }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "Created", "CreatedBy", "FlightId", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "PassengerId", "Price", "ReservationDate", "Status", "StatusId" },
                values: new object[,]
                {
                    { 11, new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9432), "admin", 11, null, "", null, "", 11, 500.0, new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9427), "Confirmed", 1 },
                    { 12, new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9438), "admin", 12, null, "", null, "", 12, 750.0, new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9436), "Confirmed", 1 }
                });

            migrationBuilder.InsertData(
                table: "FlightDetails",
                columns: new[] { "Id", "Aerobridge", "BaggageCarousel", "BoardingStatus", "CheckInCounter", "Created", "CreatedBy", "FlightDistance", "Gate", "GateTime", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Stand", "StatusId", "Terminal" },
                values: new object[,]
                {
                    { 11, true, "Carousel 5", "On Time", 22, new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9143), "admin", 2500.0, "G5", new DateTime(2023, 11, 24, 14, 51, 35, 708, DateTimeKind.Local).AddTicks(9139), null, "", null, "", "Stand 3A", 1, "Terminal 1" },
                    { 12, false, "Carousel 3", "Delayed", 18, new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9204), "admin", 3200.0, "G10", new DateTime(2023, 11, 24, 23, 51, 35, 708, DateTimeKind.Local).AddTicks(9201), null, "", null, "", "Stand 4B", 1, "Terminal 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Luggages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Luggages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.InsertData(
                table: "Airlines",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "LogoUrl", "Modified", "ModifiedBy", "Name", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(6705), "admin", null, "", "url_to_logo_american", null, "", "American Airlines", 1 },
                    { 2, new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(6752), "admin", null, "", "url_to_logo_lufthansa", null, "", "Lufthansa", 1 }
                });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "Created", "CreatedBy", "IataCode", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "StatusId", "City", "Country", "State", "Street", "ZipCode" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(6991), "admin", "LAX", null, "", null, "", "Los Angeles International Airport", 1, "Los Angeles", "USA", "CA", "1 World Way", "90045" },
                    { 2, new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(6996), "admin", "FRA", null, "", null, "", "Frankfurt Airport", 1, "Frankfurt", "Germany", "Hesse", "60547 Frankfurt", "60547" }
                });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "Id", "Created", "CreatedBy", "Email", "FirstName", "Inactivated", "InactivatedBy", "LastName", "Modified", "ModifiedBy", "PhoneNumber", "StatusId", "City", "Country", "State", "Street", "ZipCode" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7392), "admin", "johndoe@example.com", "John", null, "", "Doe", null, "", "123456789", 1, "New York", "USA", "NY", "123 Broadway", "10007" },
                    { 2, new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7397), "admin", "janesmith@example.com", "Jane", null, "", "Smith", null, "", "987654321", 1, "Berlin", "Germany", "Berlin", "Alexanderplatz 1", "10178" }
                });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "AirlineId", "BusinessClassSeats", "Created", "CreatedBy", "EconomyClassSeats", "Inactivated", "InactivatedBy", "LastMaintenanceDate", "Manufacturer", "Model", "Modified", "ModifiedBy", "Range", "SeatCapacity", "StatusId", "YearOfManufacture" },
                values: new object[,]
                {
                    { 1, 1, 100, new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7219), "admin", 200, null, "", new DateOnly(1, 1, 1), "Boeing", "777", null, "", 10820.0, 300, 1, new DateOnly(1, 1, 1) },
                    { 2, 1, 160, new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7228), "admin", 340, null, "", new DateOnly(1, 1, 1), "Airbus", "A380", null, "", 15200.0, 500, 1, new DateOnly(1, 1, 1) }
                });

            migrationBuilder.InsertData(
                table: "Luggages",
                columns: new[] { "Id", "Created", "CreatedBy", "Dimensions", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "PassengerId", "Status", "StatusId", "Type", "Weight" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7646), "admin", "22x14x9 inches", null, "", null, "", 1, "Checked", 1, "Carry-on", 15.5 },
                    { 2, new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7650), "admin", "24x16x10 inches", null, "", null, "", 2, "Checked", 1, "Checked", 20.0 }
                });

            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "Id", "AircraftId", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "StatusId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7614), "admin", null, "", null, "", "Wi-Fi", 1 },
                    { 2, 1, new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7618), "admin", null, "", null, "", "Extra Legroom", 1 }
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "AircraftId", "AirlineId", "ArrivalAirportId", "ArrivalTime", "Created", "CreatedBy", "DepartureAirportId", "DepartureTime", "FlightNumber", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Status", "StatusId" },
                values: new object[,]
                {
                    { 1, 1, 1, 2, new DateTime(2023, 11, 24, 23, 8, 13, 748, DateTimeKind.Local).AddTicks(7300), new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7304), "admin", 1, new DateTime(2023, 11, 24, 15, 8, 13, 748, DateTimeKind.Local).AddTicks(7296), "AA100", null, "", null, "", "Active", 1 },
                    { 2, 2, 2, 1, new DateTime(2023, 11, 25, 8, 8, 13, 748, DateTimeKind.Local).AddTicks(7309), new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7311), "admin", 2, new DateTime(2023, 11, 25, 0, 8, 13, 748, DateTimeKind.Local).AddTicks(7308), "LH205", null, "", null, "", "Active", 1 }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "Created", "CreatedBy", "FlightId", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "PassengerId", "Price", "ReservationDate", "Status", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7583), "admin", 1, null, "", null, "", 1, 500.0, new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7578), "Confirmed", 1 },
                    { 2, new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7588), "admin", 2, null, "", null, "", 2, 750.0, new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7587), "Confirmed", 1 }
                });

            migrationBuilder.InsertData(
                table: "FlightDetails",
                columns: new[] { "Id", "Aerobridge", "BaggageCarousel", "BoardingStatus", "CheckInCounter", "Created", "CreatedBy", "FlightDistance", "Gate", "GateTime", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Stand", "StatusId", "Terminal" },
                values: new object[,]
                {
                    { 1, true, "Carousel 5", "On Time", 22, new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7351), "admin", 2500.0, "G5", new DateTime(2023, 11, 24, 14, 38, 13, 748, DateTimeKind.Local).AddTicks(7347), null, "", null, "", "Stand 3A", 1, "Terminal 1" },
                    { 2, false, "Carousel 3", "Delayed", 18, new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7356), "admin", 3200.0, "G10", new DateTime(2023, 11, 24, 23, 38, 13, 748, DateTimeKind.Local).AddTicks(7354), null, "", null, "", "Stand 4B", 1, "Terminal 2" }
                });
        }
    }
}
