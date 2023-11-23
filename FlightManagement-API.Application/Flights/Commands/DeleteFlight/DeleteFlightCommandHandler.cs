using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Application.Common.Exceptions;
using FlightManagement_API.Application.Common.Interfaces;
using FlightManagement_API.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FlightManagement_API.Application.Flights.Commands.DeleteFlight
{
    public class DeleteFlightCommandHandler(IFlightDbContext flightDbContext) : IRequestHandler<DeleteFlightCommand>
    {
        public async Task Handle(DeleteFlightCommand request, CancellationToken cancellationToken)
        {
            var flight = await flightDbContext.Flights.Where(p => p.Id == request.FlightId).Include(p => p.FlightDetail).FirstOrDefaultAsync(cancellationToken);
            var flightDetails = flight.FlightDetail;
            if (flight == null)
            {
                throw new NotFoundException(nameof(Flight), request.FlightId);
            }
            flightDbContext.Flights.Remove(flight); 
            flightDbContext.FlightDetails.Remove(flightDetails);

            await flightDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
