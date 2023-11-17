using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace FlightManagement_API.Application.Flights.Queries.GetFlightsForBoardVm
{
    public class GetFlightsForBoardQuery : IRequest<FlightsForBoardVm>
    {
        public DateTime DepartureTime { get; set; }
    }
}
