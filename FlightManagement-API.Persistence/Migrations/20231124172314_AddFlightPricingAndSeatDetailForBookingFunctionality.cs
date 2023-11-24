using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightManagement_API.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddFlightPricingAndSeatDetailForBookingFunctionality : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SeatColumns",
                table: "Aircrafts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FlightPricing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightId = table.Column<int>(type: "int", nullable: false),
                    EconomyPrice = table.Column<double>(type: "float", nullable: false),
                    BusinessPrice = table.Column<double>(type: "float", nullable: false),
                    AvailableEconomySeats = table.Column<int>(type: "int", nullable: false),
                    AvailableBusinessSeats = table.Column<int>(type: "int", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightPricing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlightPricing_Flights_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Flights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SeatDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightPricingId = table.Column<int>(type: "int", nullable: false),
                    SeatNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialPrice = table.Column<double>(type: "float", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeatDetail_FlightPricing_FlightPricingId",
                        column: x => x.FlightPricingId,
                        principalTable: "FlightPricing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "SeatColumns" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 23, 13, 793, DateTimeKind.Local).AddTicks(3535), 6 });

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "SeatColumns" },
                values: new object[] { new DateTime(2023, 11, 24, 18, 23, 13, 793, DateTimeKind.Local).AddTicks(3545), 10 });

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

            migrationBuilder.CreateIndex(
                name: "IX_FlightPricing_FlightId",
                table: "FlightPricing",
                column: "FlightId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SeatDetail_FlightPricingId",
                table: "SeatDetail",
                column: "FlightPricingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SeatDetail");

            migrationBuilder.DropTable(
                name: "FlightPricing");

            migrationBuilder.DropColumn(
                name: "SeatColumns",
                table: "Aircrafts");

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
    }
}
