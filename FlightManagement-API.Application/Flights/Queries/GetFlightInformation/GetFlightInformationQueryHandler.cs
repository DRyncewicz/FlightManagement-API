using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FlightManagement_API.Application.Common.Interfaces;
using FlightManagement_API.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FlightManagement_API.Application.Flights.Queries.GetFlightInformation
{
    public class GetFlightInformationQueryHandler(IFlightDbContext flightDbContext, IMapper mapper) : IRequestHandler<GetFlightInformationQuery, FlightInformationVm>
    {
        public async Task<FlightInformationVm> Handle(GetFlightInformationQuery request, CancellationToken cancellationToken)
        {
            var flight = await flightDbContext.Flights.Where(p => p.Id == request.FlightId)
                .Include(p => p.FlightDetail)
                .Include(p => p.DepartureAirport)
                .Include(p => p.ArrivalAirport)
                .Include(p => p.Aircraft)
                .ThenInclude(p => p.Airline)
                .FirstOrDefaultAsync(cancellationToken);
            var flightInformationVm = mapper.Map<FlightInformationVm>(flight);

            return flightInformationVm;
        }
    }
}
 