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

namespace FlightManagement_API.Application.Aircrafts.Queries.GetAircraftInformation
{
    public class GetAircraftInformationQueryHandler(IFlightDbContext flightDbContext, IMapper mapper) : IRequestHandler<GetAircraftInformationQuery, AircraftInformationVm> 
    {
        public async Task<AircraftInformationVm> Handle(GetAircraftInformationQuery request, CancellationToken cancellationToken)
        {
            var aircraft = await flightDbContext.Aircrafts
                .Where(a => a.Id == request.AircraftId)
                .Include(a => a.Airline)
                .Include(a => a.Amenities)
                .Include(a => a.Flights)
                .ThenInclude(f => f.ArrivalAirport)
                .Include(a => a.Flights)
                .ThenInclude(f => f.DepartureAirport)
                .FirstOrDefaultAsync(cancellationToken);

            var aircraftInformationVm = mapper.Map<AircraftInformationVm>(aircraft);
            return aircraftInformationVm;
        }
    }
}
