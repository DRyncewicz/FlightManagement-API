using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace FlightManagement_API.Application.Flights.Commands.DeleteFlight
{
    public class DeleteFlightCommand : IRequest
    {
        public int FlightId { get; set; }
    }
}
