using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FlightManagement_API.Application.Common.Interfaces;
using FlightManagement_API.Domain.Entities;
using MediatR;

namespace FlightManagement_API.Application.Flights.Commands.CreateFlight
{
    public class CreateFlightCommandHandler(IFlightDbContext flightDbContext, IMapper mapper) : IRequestHandler<CreateFlightCommand, int>
    {
        public async Task<int> Handle(CreateFlightCommand request, CancellationToken cancellationToken)
        {
            var flight = mapper.Map<Flight>(request);
            await flightDbContext.Flights.AddAsync(flight, cancellationToken);

            await flightDbContext.SaveChangesAsync(cancellationToken);

            return flight.Id;
        }
    }
}

