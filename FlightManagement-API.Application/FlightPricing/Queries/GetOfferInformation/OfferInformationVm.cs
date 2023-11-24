using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FlightManagement_API.Application.Common.Mappings;

namespace FlightManagement_API.Application.FlightPricing.Queries.GetOfferInformation
{
    public class OfferInformationVm : IMapFrom<Domain.Entities.FlightPricing>
    {
        public double EconomyPrice { get; set; }

        public double BusinessPrice { get; set; }

        public int AvailableEconomySeats { get; set; }

        public int AvailableBusinessSeats { get; set; }

        public DateTime LastUpdated { get; set; }

        public List<SeatDetailDto> SeatDetails { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.FlightPricing, OfferInformationVm>();
        }
    }
}
