using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement_API.Application.Flights.Queries.GetFlightsForBoardVm
{
    public class FlightDto
    {
        public string FlightNumber { get; set; }
        
        public string DepartureIataCode { get; set; }
        
        public string ArrivalIataCode { get; set; }

        public DateTime DepartureTime { get; set; }
    }
}
