using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightManagement_API.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddAirlineConctactAndAdditionalAirlineData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CeoFirstName",
                table: "Airlines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CeoLastName",
                table: "Airlines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SiteUrl",
                table: "Airlines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "AirlineContacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AirlineId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_AirlineContacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AirlineContacts_Airlines_AirlineId",
                        column: x => x.AirlineId,
                        principalTable: "Airlines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "CeoFirstName", "CeoLastName", "Created", "SiteUrl" },
                values: new object[] { "Janusz", "Knot", new DateTime(2023, 11, 24, 12, 53, 27, 754, DateTimeKind.Local).AddTicks(9680), "https://www.aa.com" });

            migrationBuilder.UpdateData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CeoFirstName", "CeoLastName", "Created", "SiteUrl" },
                values: new object[] { "Helmuth", "Riddle", new DateTime(2023, 11, 24, 12, 53, 27, 754, DateTimeKind.Local).AddTicks(9729), "https://www.lufthansa.com" });

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
                columns: new[] { "ArrivalTime", "Created", "DepartureTime" },
                values: new object[] { new DateTime(2023, 11, 24, 23, 53, 27, 755, DateTimeKind.Local).AddTicks(508), new DateTime(2023, 11, 24, 12, 53, 27, 755, DateTimeKind.Local).AddTicks(512), new DateTime(2023, 11, 24, 15, 53, 27, 755, DateTimeKind.Local).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArrivalTime", "Created", "DepartureTime" },
                values: new object[] { new DateTime(2023, 11, 25, 8, 53, 27, 755, DateTimeKind.Local).AddTicks(517), new DateTime(2023, 11, 24, 12, 53, 27, 755, DateTimeKind.Local).AddTicks(519), new DateTime(2023, 11, 25, 0, 53, 27, 755, DateTimeKind.Local).AddTicks(515) });

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
                name: "IX_AirlineContacts_AirlineId",
                table: "AirlineContacts",
                column: "AirlineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirlineContacts");

            migrationBuilder.DropColumn(
                name: "CeoFirstName",
                table: "Airlines");

            migrationBuilder.DropColumn(
                name: "CeoLastName",
                table: "Airlines");

            migrationBuilder.DropColumn(
                name: "SiteUrl",
                table: "Airlines");

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "ReservationDate" },
                values: new object[] { new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9432), new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "ReservationDate" },
                values: new object[] { new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9438), new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "GateTime" },
                values: new object[] { new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9143), new DateTime(2023, 11, 24, 14, 51, 35, 708, DateTimeKind.Local).AddTicks(9139) });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "GateTime" },
                values: new object[] { new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9204), new DateTime(2023, 11, 24, 23, 51, 35, 708, DateTimeKind.Local).AddTicks(9201) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ArrivalTime", "Created", "DepartureTime" },
                values: new object[] { new DateTime(2023, 11, 24, 23, 21, 35, 708, DateTimeKind.Local).AddTicks(9094), new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9096), new DateTime(2023, 11, 24, 15, 21, 35, 708, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArrivalTime", "Created", "DepartureTime" },
                values: new object[] { new DateTime(2023, 11, 25, 8, 21, 35, 708, DateTimeKind.Local).AddTicks(9102), new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9104), new DateTime(2023, 11, 25, 0, 21, 35, 708, DateTimeKind.Local).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Luggages",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Luggages",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2023, 11, 24, 12, 21, 35, 708, DateTimeKind.Local).AddTicks(9248));
        }
    }
}
