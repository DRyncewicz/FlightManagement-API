
using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightManagement_API.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class NameAdjustmentOfFlightPricingAndSeatDetailsEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPricing_Flights_FlightId",
                table: "FlightPricing");

            migrationBuilder.DropForeignKey(
                name: "FK_SeatDetail_FlightPricing_FlightPricingId",
                table: "SeatDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SeatDetail",
                table: "SeatDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightPricing",
                table: "FlightPricing");

            migrationBuilder.RenameTable(
                name: "SeatDetail",
                newName: "SeatDetails");

            migrationBuilder.RenameTable(
                name: "FlightPricing",
                newName: "FlightPricings");

            migrationBuilder.RenameIndex(
                name: "IX_SeatDetail_FlightPricingId",
                table: "SeatDetails",
                newName: "IX_SeatDetails_FlightPricingId");

            migrationBuilder.RenameIndex(
                name: "IX_FlightPricing_FlightId",
                table: "FlightPricings",
                newName: "IX_FlightPricings_FlightId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SeatDetails",
                table: "SeatDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightPricings",
                table: "FlightPricings",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 20, 15, 56, 158, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 20, 15, 56, 158, DateTimeKind.Local).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 20, 15, 56, 158, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 20, 15, 56, 158, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 20, 15, 56, 158, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 20, 15, 56, 158, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 20, 15, 56, 158, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 20, 15, 56, 158, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "ReservationDate" },
                values: new object[] { new DateTime(2023, 11, 24, 20, 15, 56, 158, DateTimeKind.Local).AddTicks(4632), new DateTime(2023, 11, 24, 20, 15, 56, 158, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "ReservationDate" },
                values: new object[] { new DateTime(2023, 11, 24, 20, 15, 56, 158, DateTimeKind.Local).AddTicks(4638), new DateTime(2023, 11, 24, 20, 15, 56, 158, DateTimeKind.Local).AddTicks(4636) });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "GateTime" },
                values: new object[] { new DateTime(2023, 11, 24, 20, 15, 56, 158, DateTimeKind.Local).AddTicks(4404), new DateTime(2023, 11, 24, 22, 45, 56, 158, DateTimeKind.Local).AddTicks(4402) });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "GateTime" },
                values: new object[] { new DateTime(2023, 11, 24, 20, 15, 56, 158, DateTimeKind.Local).AddTicks(4411), new DateTime(2023, 11, 25, 7, 45, 56, 158, DateTimeKind.Local).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ArrivalTime", "Created", "DepartureTime" },
                values: new object[] { new DateTime(2023, 11, 25, 7, 15, 56, 158, DateTimeKind.Local).AddTicks(4235), new DateTime(2023, 11, 24, 20, 15, 56, 158, DateTimeKind.Local).AddTicks(4237), new DateTime(2023, 11, 24, 23, 15, 56, 158, DateTimeKind.Local).AddTicks(4231) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArrivalTime", "Created", "DepartureTime" },
                values: new object[] { new DateTime(2023, 11, 25, 16, 15, 56, 158, DateTimeKind.Local).AddTicks(4243), new DateTime(2023, 11, 24, 20, 15, 56, 158, DateTimeKind.Local).AddTicks(4245), new DateTime(2023, 11, 25, 8, 15, 56, 158, DateTimeKind.Local).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "Luggages",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 20, 15, 56, 158, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "Luggages",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 20, 15, 56, 158, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 20, 15, 56, 158, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 20, 15, 56, 158, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPricings_Flights_FlightId",
                table: "FlightPricings",
                column: "FlightId",
                principalTable: "Flights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SeatDetails_FlightPricings_FlightPricingId",
                table: "SeatDetails",
                column: "FlightPricingId",
                principalTable: "FlightPricings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPricings_Flights_FlightId",
                table: "FlightPricings");

            migrationBuilder.DropForeignKey(
                name: "FK_SeatDetails_FlightPricings_FlightPricingId",
                table: "SeatDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SeatDetails",
                table: "SeatDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightPricings",
                table: "FlightPricings");

            migrationBuilder.RenameTable(
                name: "SeatDetails",
                newName: "SeatDetail");

            migrationBuilder.RenameTable(
                name: "FlightPricings",
                newName: "FlightPricing");

            migrationBuilder.RenameIndex(
                name: "IX_SeatDetails_FlightPricingId",
                table: "SeatDetail",
                newName: "IX_SeatDetail_FlightPricingId");

            migrationBuilder.RenameIndex(
                name: "IX_FlightPricings_FlightId",
                table: "FlightPricing",
                newName: "IX_FlightPricing_FlightId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SeatDetail",
                table: "SeatDetail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightPricing",
                table: "FlightPricing",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 18, 23, 13, 793, DateTimeKind.Local).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 18, 23, 13, 793, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 18, 23, 13, 793, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 18, 23, 13, 793, DateTimeKind.Local).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 18, 23, 13, 793, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 18, 23, 13, 793, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 18, 23, 13, 793, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 18, 23, 13, 793, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "ReservationDate" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 23, 13, 793, DateTimeKind.Local).AddTicks(3916), new DateTime(2023, 11, 24, 18, 23, 13, 793, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "ReservationDate" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 23, 13, 793, DateTimeKind.Local).AddTicks(3922), new DateTime(2023, 11, 24, 18, 23, 13, 793, DateTimeKind.Local).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "GateTime" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 23, 13, 793, DateTimeKind.Local).AddTicks(3621), new DateTime(2023, 11, 24, 20, 53, 13, 793, DateTimeKind.Local).AddTicks(3618) });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "GateTime" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 23, 13, 793, DateTimeKind.Local).AddTicks(3627), new DateTime(2023, 11, 25, 5, 53, 13, 793, DateTimeKind.Local).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ArrivalTime", "Created", "DepartureTime" },
                values: new object[] { new DateTime(2023, 11, 25, 5, 23, 13, 793, DateTimeKind.Local).AddTicks(3581), new DateTime(2023, 11, 24, 18, 23, 13, 793, DateTimeKind.Local).AddTicks(3585), new DateTime(2023, 11, 24, 21, 23, 13, 793, DateTimeKind.Local).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArrivalTime", "Created", "DepartureTime" },
                values: new object[] { new DateTime(2023, 11, 25, 14, 23, 13, 793, DateTimeKind.Local).AddTicks(3589), new DateTime(2023, 11, 24, 18, 23, 13, 793, DateTimeKind.Local).AddTicks(3591), new DateTime(2023, 11, 25, 6, 23, 13, 793, DateTimeKind.Local).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "Luggages",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 18, 23, 13, 793, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "Luggages",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 18, 23, 13, 793, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 18, 23, 13, 793, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 18, 23, 13, 793, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPricing_Flights_FlightId",
                table: "FlightPricing",
                column: "FlightId",
                principalTable: "Flights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SeatDetail_FlightPricing_FlightPricingId",
                table: "SeatDetail",
                column: "FlightPricingId",
                principalTable: "FlightPricing",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
