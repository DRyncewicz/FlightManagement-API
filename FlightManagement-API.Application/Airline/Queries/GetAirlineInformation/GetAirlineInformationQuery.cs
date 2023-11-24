using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace FlightManagement_API.Application.Airline.Queries.GetAirlineInformation
{
    public class GetAirlineInformationQuery : IRequest<AirlineInformationVm>
    {
        public int AirlineId { get; set; }
    }
}
