using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FlightManagement_API.Application.Common.Interfaces.Database;
using FlightManagement_API.Domain.Entities;
using MediatR;

namespace FlightManagement_API.Application.Airline.Commands.CreateAirlineContact
{
    public class CreateAirlineContactCommandHandler(IFlightDbContext flightDbContext, IMapper mapper) : IRequestHandler<CreateAirlineContactCommand, int>
    {
        public async Task<int> Handle(CreateAirlineContactCommand request, CancellationToken cancellationToken)
        {
            var airlineContact = mapper.Map<AirlineContact>(request);
            await flightDbContext.AirlineContacts.AddAsync(airlineContact, cancellationToken);
            await flightDbContext.SaveChangesAsync(cancellationToken);

            return airlineContact.Id;
        }
    }
}
