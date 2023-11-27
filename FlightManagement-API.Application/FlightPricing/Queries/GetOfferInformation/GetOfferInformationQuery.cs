using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Application.Flights.Queries.GetFlightInformation;
using MediatR;

namespace FlightManagement_API.Application.FlightPricing.Queries.GetOfferInformation
{
    public class GetOfferInformationQuery : IRequest<OfferInformationVm>
    {
        public int OfferId { get; set; }
    }
}
