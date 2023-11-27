using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace FlightManagement_API.Application.Flights.Queries.GetFilteredFlights
{
    public class GetFilteredFlightsQuery : IRequest<ListFilteredFlightsVm>
    {
        public DateTime? DepartureDate { get; set; }

        public DateTime? ArrivalDate { get; set; }

        public string DepartureAirport { get; set; }

        public string ArrivalAirport { get; set; }

        public double? MaxPrice { get; set; }

        public int CurrentPage { get; set; }

        public int PageSize { get; set; }
    }
}
