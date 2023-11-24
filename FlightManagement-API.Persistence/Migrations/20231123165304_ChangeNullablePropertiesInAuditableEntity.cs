using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightManagement_API.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNullablePropertiesInAuditableEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "InactivatedBy",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Luggages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "InactivatedBy",
                table: "Luggages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "InactivatedBy",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "FlightDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "InactivatedBy",
                table: "FlightDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "InactivatedBy",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Amenities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "InactivatedBy",
                table: "Amenities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Airports",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "InactivatedBy",
                table: "Airports",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Airlines",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "InactivatedBy",
                table: "Airlines",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Aircrafts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "InactivatedBy",
                table: "Aircrafts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 11, 23, 17, 53, 3, 429, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 11, 23, 17, 53, 3, 429, DateTimeKind.Local).AddTicks(5559));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InactivatedBy",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Luggages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InactivatedBy",
                table: "Luggages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InactivatedBy",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "FlightDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InactivatedBy",
                table: "FlightDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InactivatedBy",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Amenities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InactivatedBy",
                table: "Amenities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Airports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InactivatedBy",
                table: "Airports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Airlines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InactivatedBy",
                table: "Airlines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Aircrafts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InactivatedBy",
                table: "Aircrafts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "ReservationDate" },
                values: new object[] { new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5706), new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "ReservationDate" },
                values: new object[] { new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5712), new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "GateTime" },
                values: new object[] { new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5510), new DateTime(2023, 11, 23, 17, 48, 34, 13, DateTimeKind.Local).AddTicks(5507) });

            migrationBuilder.UpdateData(
                table: "FlightDetails",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "GateTime" },
                values: new object[] { new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5515), new DateTime(2023, 11, 24, 2, 48, 34, 13, DateTimeKind.Local).AddTicks(5513) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "Created", "DepartureTime" },
                values: new object[] { new DateTime(2023, 11, 24, 2, 18, 34, 13, DateTimeKind.Local).AddTicks(5469), new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5471), new DateTime(2023, 11, 23, 18, 18, 34, 13, DateTimeKind.Local).AddTicks(5466) });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "Created", "DepartureTime" },
                values: new object[] { new DateTime(2023, 11, 24, 11, 18, 34, 13, DateTimeKind.Local).AddTicks(5477), new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5479), new DateTime(2023, 11, 24, 3, 18, 34, 13, DateTimeKind.Local).AddTicks(5475) });

            migrationBuilder.UpdateData(
                table: "Luggages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "Luggages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Passengers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 11, 23, 15, 18, 34, 13, DateTimeKind.Local).AddTicks(5549));
        }
    }
}
