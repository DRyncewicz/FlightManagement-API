using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FlightManagement_API.Application.Common.Mappings;
using FlightManagement_API.Domain.Entities;
using MediatR;

namespace FlightManagement_API.Application.Flights.Commands.CreateFlight
{
    public class CreateFlightCommand : IRequest<int>, IMapFrom<Flight>
    {
        public string FlightNumber { get; set; }

        public int DepartureAirportId { get; set; }

        public int ArrivalAirportId { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }

        public int AircraftId { get; set; }

        public string Status { get; set; }

        public string Gate { get; set; }

        public string Terminal { get; set; }

        public string Stand { get; set; }

        public string BaggageCarousel { get; set; }

        public int CheckInCounter { get; set; }

        public string BoardingStatus { get; set; }

        public bool Aerobridge { get; set; }

        public DateTime GateTime { get; set; }

        public double FlightDistance { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateFlightCommand, Flight>()
                .ForMember(flight => flight.FlightDetail, opt => opt.MapFrom(command => new FlightDetail
                {
                    Gate = command.Gate,
                    Terminal = command.Terminal,
                    Stand = command.Stand,
                    BaggageCarousel = command.BaggageCarousel,
                    CheckInCounter = command.CheckInCounter,
                    BoardingStatus = command.BoardingStatus,
                    Aerobridge = command.Aerobridge,
                    GateTime = command.GateTime,
                    FlightDistance = command.FlightDistance
                }));
        }
    }
}
