using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FlightManagement_API.Application.Common.Interfaces.Database;
using FlightManagement_API.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FlightManagement_API.Application.Airline.Queries.GetAirlineInformation
{
    internal class GetAirlineInformationQueryHandler(IFlightDbContext flightDbContext, IMapper mapper) : IRequestHandler<GetAirlineInformationQuery, AirlineInformationVm>
    {
        public async Task<AirlineInformationVm> Handle(GetAirlineInformationQuery request, CancellationToken cancellationToken)
        {
            var airline =  await flightDbContext.Airlines.Where(a => a.Id == request.AirlineId)
                .Include(a => a.Contacts)
                .FirstOrDefaultAsync(cancellationToken);

            return mapper.Map<AirlineInformationVm>(airline);
        }
    }
}
