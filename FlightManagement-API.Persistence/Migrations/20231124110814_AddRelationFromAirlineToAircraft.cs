using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightManagement_API.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationFromAirlineToAircraft : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AirlineId",
                table: "Aircrafts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AirlineId", "BusinessClassSeats", "Created", "EconomyClassSeats", "Range" },
                values: new object[] { 1, 100, new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7219), 200, 10820.0 });

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AirlineId", "BusinessClassSeats", "Created", "EconomyClassSeats", "Range" },
                values: new object[] { 1, 160, new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7228), 340, 15200.0 });

            migrationBuilder.UpdateData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "ReservationDate" },
                values: new object[] { new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7583), new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7578) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "ReservationDate" },
                values: new object[] { new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7588), new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "GateTime" },
                values: new object[] { new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7351), new DateTime(2023, 11, 24, 14, 38, 13, 748, DateTimeKind.Local).AddTicks(7347) });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "GateTime" },
                values: new object[] { new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7356), new DateTime(2023, 11, 24, 23, 38, 13, 748, DateTimeKind.Local).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "Created", "DepartureTime" },
                values: new object[] { new DateTime(2023, 11, 24, 23, 8, 13, 748, DateTimeKind.Local).AddTicks(7300), new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7304), new DateTime(2023, 11, 24, 15, 8, 13, 748, DateTimeKind.Local).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "Created", "DepartureTime" },
                values: new object[] { new DateTime(2023, 11, 25, 8, 8, 13, 748, DateTimeKind.Local).AddTicks(7309), new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7311), new DateTime(2023, 11, 25, 0, 8, 13, 748, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "Luggages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "Luggages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 8, 13, 748, DateTimeKind.Local).AddTicks(7397));

            migrationBuilder.CreateIndex(
                name: "IX_Aircrafts_AirlineId",
                table: "Aircrafts",
                column: "AirlineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_Airlines_AirlineId",
                table: "Aircrafts",
                column: "AirlineId",
                principalTable: "Airlines",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_Airlines_AirlineId",
                table: "Aircrafts");

            migrationBuilder.DropIndex(
                name: "IX_Aircrafts_AirlineId",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "AirlineId",
                table: "Aircrafts");

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BusinessClassSeats", "Created", "EconomyClassSeats", "Range" },
                values: new object[] { 0, new DateTime(2023, 11, 23, 17, 53, 3, 429, DateTimeKind.Local).AddTicks(5551), 0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BusinessClassSeats", "Created", "EconomyClassSeats", "Range" },
                values: new object[] { 0, new DateTime(2023, 11, 23, 17, 53, 3, 429, DateTimeKind.Local).AddTicks(5559), 0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 11, 23, 17, 53, 3, 429, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 11, 23, 17, 53, 3, 429, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 11, 23, 17, 53, 3, 429, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 11, 23, 17, 53, 3, 429, DateTimeKind.Local).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 11, 23, 17, 53, 3, 429, DateTimeKind.Local).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 11, 23, 17, 53, 3, 429, DateTimeKind.Local).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "ReservationDate" },
                values: new object[] { new DateTime(2023, 11, 23, 17, 53, 3, 429, DateTimeKind.Local).AddTicks(5920), new DateTime(2023, 11, 23, 17, 53, 3, 429, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "ReservationDate" },
                values: new object[] { new DateTime(2023, 11, 23, 17, 53, 3, 429, DateTimeKind.Local).AddTicks(5926), new DateTime(2023, 11, 23, 17, 53, 3, 429, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "GateTime" },
                values: new object[] { new DateTime(2023, 11, 23, 17, 53, 3, 429, DateTimeKind.Local).AddTicks(5644), new DateTime(2023, 11, 23, 20, 23, 3, 429, DateTimeKind.Local).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "GateTime" },
                values: new object[] { new DateTime(2023, 11, 23, 17, 53, 3, 429, DateTimeKind.Local).AddTicks(5650), new DateTime(2023, 11, 24, 5, 23, 3, 429, DateTimeKind.Local).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "Created", "DepartureTime" },
                values: new object[] { new DateTime(2023, 11, 24, 4, 53, 3, 429, DateTimeKind.Local).AddTicks(5598), new DateTime(2023, 11, 23, 17, 53, 3, 429, DateTimeKind.Local).AddTicks(5600), new DateTime(2023, 11, 23, 20, 53, 3, 429, DateTimeKind.Local).AddTicks(5593) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "Created", "DepartureTime" },
                values: new object[] { new DateTime(2023, 11, 24, 13, 53, 3, 429, DateTimeKind.Local).AddTicks(5606), new DateTime(2023, 11, 23, 17, 53, 3, 429, DateTimeKind.Local).AddTicks(5608), new DateTime(2023, 11, 24, 5, 53, 3, 429, DateTimeKind.Local).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "Luggages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 11, 23, 17, 53, 3, 429, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "Luggages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 11, 23, 17, 53, 3, 429, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 11, 23, 17, 53, 3, 429, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 11, 23, 17, 53, 3, 429, DateTimeKind.Local).AddTicks(5688));
        }
    }
}
