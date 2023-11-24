using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FlightManagement_API.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FlightManagement_API.Application.Flights.Queries.GetFlightsForBoardVm
{
    public class GetFlightsForBoardQueryHandler(IFlightDbContext flightDbContext, IMapper mapper, IDateTime dateTime) : IRequestHandler<GetFlightsForBoardQuery, FlightsForBoardVm>
    {
        public async Task<FlightsForBoardVm> Handle(GetFlightsForBoardQuery request, CancellationToken cancellationToken)
        {
            var flights = await flightDbContext.Flights
                .Include(p => p.ArrivalAirport)
                .Include(p => p.DepartureAirport)
                .Where(f => f.DepartureTime > dateTime.Now)
                .Skip(request.PageSize * (request.CurrentPage - 1)).Take(request.PageSize).ToListAsync(cancellationToken);

            var flightsDto = mapper.Map<List<FlightDto>>(flights);
            var flightForBoardVm = new FlightsForBoardVm()
            {
                Flights = flightsDto,
                CurrentPage = request.CurrentPage,
                PageSize = request.PageSize
            };

            return flightForBoardVm;
        }
    }
}
