using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement_API.Application.Flights.Queries.GetFlightsForBoardVm
{
    public class FlightsForBoardVm
    {
        public List<FlightDto> Flights { get; set; }

        public int CurrentPage { get; set; }

        public int PageSize { get; set; }
    }
}
