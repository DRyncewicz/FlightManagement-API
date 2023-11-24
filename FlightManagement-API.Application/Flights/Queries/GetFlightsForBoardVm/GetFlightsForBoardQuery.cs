using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Application.Common.Interfaces;
using MediatR;

namespace FlightManagement_API.Application.Flights.Queries.GetFlightsForBoardVm
{
    public class GetFlightsForBoardQuery() : IRequest<FlightsForBoardVm>
    {
        public int PageSize { get; set; }

        public int CurrentPage { get; set; }
    }
}
