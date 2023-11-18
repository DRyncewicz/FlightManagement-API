using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FlightManagement_API.Application.Flights.Commands.DeleteFlight
{
    public class DeleteFlightCommandHandler(IFlightDbContext flightDbContext) : IRequestHandler<DeleteFlightCommand>
    {
        public async Task Handle(DeleteFlightCommand request, CancellationToken cancellationToken)
        {
            var flight = await flightDbContext.Flights.Where(p => p.Id == request.FlightId).FirstOrDefaultAsync(cancellationToken);
            var flightDetails = flight.FlightDetail;
            flightDbContext.Flights.Remove(flight); 
            flightDbContext.FlightDetails.Remove(flightDetails);

            await flightDbContext.SaveChangesAsync(cancellationToken);

            return;
        }
    }
}
