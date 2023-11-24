using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightManagement_API.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class DropRedundantRelationBeetweenAirlineAndFlight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Airlines_AirlineId",
                table: "Flights");

            migrationBuilder.DropIndex(
                name: "IX_Flights_AirlineId",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "AirlineId",
                table: "Flights");

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 16, 54, 28, 652, DateTimeKind.Local).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 16, 54, 28, 652, DateTimeKind.Local).AddTicks(6019));

            migrationBuilder.UpdateData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 16, 54, 28, 652, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 16, 54, 28, 652, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 16, 54, 28, 652, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 16, 54, 28, 652, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 16, 54, 28, 652, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 16, 54, 28, 652, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "ReservationDate" },
                values: new object[] { new DateTime(2023, 11, 24, 16, 54, 28, 652, DateTimeKind.Local).AddTicks(6385), new DateTime(2023, 11, 24, 16, 54, 28, 652, DateTimeKind.Local).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "ReservationDate" },
                values: new object[] { new DateTime(2023, 11, 24, 16, 54, 28, 652, DateTimeKind.Local).AddTicks(6391), new DateTime(2023, 11, 24, 16, 54, 28, 652, DateTimeKind.Local).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "GateTime" },
                values: new object[] { new DateTime(2023, 11, 24, 16, 54, 28, 652, DateTimeKind.Local).AddTicks(6101), new DateTime(2023, 11, 24, 19, 24, 28, 652, DateTimeKind.Local).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "GateTime" },
                values: new object[] { new DateTime(2023, 11, 24, 16, 54, 28, 652, DateTimeKind.Local).AddTicks(6107), new DateTime(2023, 11, 25, 4, 24, 28, 652, DateTimeKind.Local).AddTicks(6105) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ArrivalTime", "Created", "DepartureTime" },
                values: new object[] { new DateTime(2023, 11, 25, 3, 54, 28, 652, DateTimeKind.Local).AddTicks(6060), new DateTime(2023, 11, 24, 16, 54, 28, 652, DateTimeKind.Local).AddTicks(6062), new DateTime(2023, 11, 24, 19, 54, 28, 652, DateTimeKind.Local).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArrivalTime", "Created", "DepartureTime" },
                values: new object[] { new DateTime(2023, 11, 25, 12, 54, 28, 652, DateTimeKind.Local).AddTicks(6067), new DateTime(2023, 11, 24, 16, 54, 28, 652, DateTimeKind.Local).AddTicks(6070), new DateTime(2023, 11, 25, 4, 54, 28, 652, DateTimeKind.Local).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "Luggages",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 16, 54, 28, 652, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Luggages",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 16, 54, 28, 652, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 16, 54, 28, 652, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 16, 54, 28, 652, DateTimeKind.Local).AddTicks(6150));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AirlineId",
                table: "Flights",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 53, 27, 755, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 53, 27, 755, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 53, 27, 754, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 53, 27, 754, DateTimeKind.Local).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 53, 27, 755, DateTimeKind.Local).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 53, 27, 755, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 53, 27, 755, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 53, 27, 755, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "ReservationDate" },
                values: new object[] { new DateTime(2023, 11, 24, 12, 53, 27, 755, DateTimeKind.Local).AddTicks(760), new DateTime(2023, 11, 24, 12, 53, 27, 755, DateTimeKind.Local).AddTicks(755) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "ReservationDate" },
                values: new object[] { new DateTime(2023, 11, 24, 12, 53, 27, 755, DateTimeKind.Local).AddTicks(765), new DateTime(2023, 11, 24, 12, 53, 27, 755, DateTimeKind.Local).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "GateTime" },
                values: new object[] { new DateTime(2023, 11, 24, 12, 53, 27, 755, DateTimeKind.Local).AddTicks(547), new DateTime(2023, 11, 24, 15, 23, 27, 755, DateTimeKind.Local).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "GateTime" },
                values: new object[] { new DateTime(2023, 11, 24, 12, 53, 27, 755, DateTimeKind.Local).AddTicks(553), new DateTime(2023, 11, 25, 0, 23, 27, 755, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AirlineId", "ArrivalTime", "Created", "DepartureTime" },
                values: new object[] { 11, new DateTime(2023, 11, 24, 23, 53, 27, 755, DateTimeKind.Local).AddTicks(508), new DateTime(2023, 11, 24, 12, 53, 27, 755, DateTimeKind.Local).AddTicks(512), new DateTime(2023, 11, 24, 15, 53, 27, 755, DateTimeKind.Local).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AirlineId", "ArrivalTime", "Created", "DepartureTime" },
                values: new object[] { 12, new DateTime(2023, 11, 25, 8, 53, 27, 755, DateTimeKind.Local).AddTicks(517), new DateTime(2023, 11, 24, 12, 53, 27, 755, DateTimeKind.Local).AddTicks(519), new DateTime(2023, 11, 25, 0, 53, 27, 755, DateTimeKind.Local).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "Luggages",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 53, 27, 755, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "Luggages",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 53, 27, 755, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 53, 27, 755, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 53, 27, 755, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.CreateIndex(
                name: "IX_Flights_AirlineId",
                table: "Flights",
                column: "AirlineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Airlines_AirlineId",
                table: "Flights",
                column: "AirlineId",
                principalTable: "Airlines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
