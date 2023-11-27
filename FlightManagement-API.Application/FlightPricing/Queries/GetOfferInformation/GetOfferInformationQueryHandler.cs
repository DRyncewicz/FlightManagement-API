using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FlightManagement_API.Application.Common.Interfaces.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FlightManagement_API.Application.FlightPricing.Queries.GetOfferInformation
{
    public class GetOfferInformationQueryHandler(IFlightDbContext flightDbContext, IMapper mapper) : IRequestHandler<GetOfferInformationQuery, OfferInformationVm>
    {
        public async Task<OfferInformationVm> Handle(GetOfferInformationQuery request, CancellationToken cancellationToken)
        {
            var flightPricing = await flightDbContext.FlightPricings.Where(fp => fp.Id == request.OfferId)
                .Include(fp => fp.SeatDetails).FirstOrDefaultAsync(cancellationToken);

            return mapper.Map<OfferInformationVm>(flightPricing);
        }
    }
}
