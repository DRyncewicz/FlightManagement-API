using FlightManagement_API.Application.Common.Exceptions;
using FlightManagement_API.Application.Common.Interfaces;
using FlightManagement_API.Application.Flights.Commands.DeleteFlight;
using FlightManagement_API.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Application.Helpers;

namespace FlightManagement_API.Application.Flights.Commands.UpdateFlight
{
    public class UpdateFlightCommandHandler(IFlightDbContext flightDbContext, PatchHelper patchHelper) : IRequestHandler<UpdateFlightCommand, int>
    {
        public async Task<int> Handle(UpdateFlightCommand request, CancellationToken cancellationToken)
        {
            var flight = await flightDbContext.Flights.Where(p => p.Id == request.FlightId).Include(p => p.FlightDetail).FirstOrDefaultAsync(cancellationToken);
            if (flight == null)
            {
                throw new NotFoundException(nameof(Flight), request.FlightId);
            }

            patchHelper.MapIfNotNull(request.FlightNumber, value => flight.FlightNumber = value);
            patchHelper.MapIfNotNull(request.DepartureAirportId, value => flight.DepartureAirportId = value.GetValueOrDefault());
            patchHelper.MapIfNotNull(request.ArrivalAirportId, value => flight.ArrivalAirportId = value.GetValueOrDefault());
            patchHelper.MapIfNotNull(request.DepartureTime, value => flight.DepartureTime = value.GetValueOrDefault());
            patchHelper.MapIfNotNull(request.ArrivalTime, value => flight.ArrivalTime = value.GetValueOrDefault());
            patchHelper.MapIfNotNull(request.AirlineId, value => flight.AirlineId = value.GetValueOrDefault());
            patchHelper.MapIfNotNull(request.AircraftId, value => flight.AircraftId = value.GetValueOrDefault());
            patchHelper.MapIfNotNull(request.Status, value => flight.Status = value);

            if (flight.FlightDetail != null)
            {
                patchHelper.MapIfNotNull(request.Terminal, value => flight.FlightDetail.Terminal = value);
                patchHelper.MapIfNotNull(request.Gate, value => flight.FlightDetail.Gate = value);
                patchHelper.MapIfNotNull(request.Stand, value => flight.FlightDetail.Stand = value);
                patchHelper.MapIfNotNull(request.BaggageCarousel, value => flight.FlightDetail.BaggageCarousel = value);
                patchHelper.MapIfNotNull(request.CheckInCounter, value => flight.FlightDetail.CheckInCounter = value.GetValueOrDefault());
                patchHelper.MapIfNotNull(request.BoardingStatus, value => flight.FlightDetail.BoardingStatus = value);
                patchHelper.MapIfNotNull(request.Aerobridge, value => flight.FlightDetail.Aerobridge = value.GetValueOrDefault());
                patchHelper.MapIfNotNull(request.GateTime, value => flight.FlightDetail.GateTime = value.GetValueOrDefault());
                patchHelper.MapIfNotNull(request.FlightDistance, value => flight.FlightDetail.FlightDistance = value.GetValueOrDefault());
            }

            flightDbContext.Flights.Update(flight);
            await flightDbContext.SaveChangesAsync(cancellationToken);
            return flight.Id;
        }
    }
}
