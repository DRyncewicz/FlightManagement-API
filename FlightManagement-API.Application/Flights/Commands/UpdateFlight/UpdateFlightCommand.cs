using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace FlightManagement_API.Application.Flights.Commands.UpdateFlight
{
    public class UpdateFlightCommand : IRequest<int>
    {
        public int FlightId { get; set; }

        public string? FlightNumber { get; set; }

        public int? DepartureAirportId { get; set; }

        public int? ArrivalAirportId { get; set; }

        public DateTime? DepartureTime { get; set; }

        public DateTime? ArrivalTime { get; set; }

        public int? AirlineId { get; set; }

        public int? AircraftId { get; set; }

        public string? Status { get; set; }

        public string? Gate { get; set; }

        public string? Terminal { get; set; }

        public string? Stand { get; set; }

        public string? BaggageCarousel { get; set; }

        public int? CheckInCounter { get; set; }

        public string? BoardingStatus { get; set; }

        public bool? Aerobridge { get; set; }

        public DateTime? GateTime { get; set; }

        public double? FlightDistance { get; set; }
    }
}
