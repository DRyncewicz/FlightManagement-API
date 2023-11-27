using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FlightManagement_API.Application.Common.Interfaces.Database;
using MediatR;

namespace FlightManagement_API.Application.Airline.Commands.CreateAirline
{
    public class CreateAirlineCommandHandler(IFlightDbContext flightDbContext, IMapper mapper) : IRequestHandler<CreateAirlineCommand,  int>
    {
        public async Task<int> Handle(CreateAirlineCommand request, CancellationToken cancellationToken)
        {
            var airline = mapper.Map<Domain.Entities.Airline>(request);
            await flightDbContext.Airlines.AddAsync(airline, cancellationToken);
            await flightDbContext.SaveChangesAsync(cancellationToken);

            return airline.Id;
        }
    }
}
