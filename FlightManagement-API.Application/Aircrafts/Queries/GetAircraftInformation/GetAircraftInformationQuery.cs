using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace FlightManagement_API.Application.Aircrafts.Queries.GetAircraftInformation
{
    public class GetAircraftInformationQuery : IRequest<AircraftInformationVm>
    {
        public int AircraftId { get; set; }
    }
}
