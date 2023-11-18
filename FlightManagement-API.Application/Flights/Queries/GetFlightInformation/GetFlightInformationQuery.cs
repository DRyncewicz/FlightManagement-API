using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace FlightManagement_API.Application.Flights.Queries.GetFlightInformation
{
    public class GetFlightInformationQuery : IRequest<FlightInformationVm>
    {
        public int FlightId { get; set; }
    }
}
