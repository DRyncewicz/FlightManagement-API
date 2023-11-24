using FlightManagement_API.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Domain.Entities;
using AutoMapper;

namespace FlightManagement_API.Application.Aircrafts.Commands.CreateAircraft
{
    public class CreateAircraftCommandHandler(IFlightDbContext flightDbContext, IMapper mapper) : IRequestHandler<CreateAircraftCommand, int>
    {
        public async Task<int> Handle(CreateAircraftCommand request, CancellationToken cancellationToken)
        {
            var aircraft = mapper.Map<Aircraft>(request);
            flightDbContext.Aircrafts.Add(aircraft);
            await flightDbContext.SaveChangesAsync(cancellationToken);

            return aircraft.Id;
        }
    }
}
