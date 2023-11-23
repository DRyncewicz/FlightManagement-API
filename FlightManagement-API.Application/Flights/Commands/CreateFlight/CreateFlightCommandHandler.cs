using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Application.Common.Interfaces;
using FlightManagement_API.Domain.Entities;
using MediatR;

namespace FlightManagement_API.Application.Flights.Commands.CreateFlight
{
    public class CreateFlightCommandHandler(IFlightDbContext flightDbContext) : IRequestHandler<CreateFlightCommand, int>
    {
        public async Task<int> Handle(CreateFlightCommand request, CancellationToken cancellationToken)
        {
            Flight flight = new()
            {
                FlightNumber = request.FlightNumber,
                DepartureAirportId = request.DepartureAirportId,
                ArrivalAirportId = request.ArrivalAirportId,
                DepartureTime = request.DepartureTime,
                ArrivalTime = request.ArrivalTime,
                AirlineId = request.AirlineId,
                AircraftId = request.AircraftId,
                Status = request.Status,
                FlightDetail = new FlightDetail()
                {
                    Gate = request.Gate,
                    Terminal = request.Terminal,
                    Stand = request.Stand,
                    BaggageCarousel = request.BaggageCarousel,
                    CheckInCounter = request.CheckInCounter,
                    BoardingStatus = request.BoardingStatus,
                    Aerobridge = request.Aerobridge,
                    GateTime = request.GateTime,
                    FlightDistance = request.FlightDistance
                }
            };


            //FlightDetail flightDetail = new()
            //{
            //    Id = flight.Id,
            //    Gate = request.Gate,
            //    Terminal = request.Terminal,
            //    Stand = request.Stand,
            //    BaggageCarousel = request.BaggageCarousel,
            //    CheckInCounter = request.CheckInCounter,
            //    BoardingStatus = request.BoardingStatus,
            //    Aerobridge = request.Aerobridge,
            //    GateTime = request.GateTime,
            //    FlightDistance = request.FlightDistance
            //};
            flightDbContext.Flights.Add(flight);
            //flightDbContext.FlightDetails.Add(flightDetail);

            await flightDbContext.SaveChangesAsync(cancellationToken);
            return flight.Id;
        }
    }
}
