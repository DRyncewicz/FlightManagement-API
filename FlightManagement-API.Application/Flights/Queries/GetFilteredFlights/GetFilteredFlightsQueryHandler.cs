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

namespace FlightManagement_API.Application.Flights.Queries.GetFilteredFlights
{
    public class GetFilteredFlightsQueryHandler(IFlightDbContext flightDbContext, IMapper mapper) : IRequestHandler<GetFilteredFlightsQuery, ListFilteredFlightsVm>
    {
        public async Task<ListFilteredFlightsVm> Handle(GetFilteredFlightsQuery request, CancellationToken cancellationToken)
        {
            IQueryable<Flight> query = flightDbContext.Flights
                .Include(f => f.FlightPricing)
                .Include(f => f.ArrivalAirport)
                .Include(f => f.DepartureAirport);

            query = query.Where(f => f.DepartureAirport.IataCode == request.DepartureAirport &&
                                     f.ArrivalAirport.IataCode == request.ArrivalAirport);
            if (request.DepartureDate.HasValue)
            {
                query = query.Where(f => f.DepartureTime.Date == request.DepartureDate.Value.Date);
            }
            if (request.ArrivalDate.HasValue)
            {
                query = query.Where(f => f.ArrivalTime.Date == request.ArrivalDate.Value.Date);
            }
            if (request.MaxPrice.HasValue)
            {
                query = query.Where(f => f.FlightPricing.EconomyPrice < request.MaxPrice.Value);
            }
            var flights = await query.Skip(request.PageSize * (request.CurrentPage - 1))
                .Take(request.PageSize).ToListAsync(cancellationToken);
            ListFilteredFlightsVm filteredFlightsVm = new ListFilteredFlightsVm()
            {
                FilteredFlights = mapper.Map<List<FilteredFlightDto>>(flights),
                PageSize = request.PageSize,
                CurrentPage = request.CurrentPage
            };

            return filteredFlightsVm;
        }
    }
}
