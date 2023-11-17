using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement_API.Application.Flights.Queries.GetFlightsForBoardVm
{
    public class FlightsForBoardVm
    {
        ICollection<FlightDto> Flights { get; set; }
    }
}
