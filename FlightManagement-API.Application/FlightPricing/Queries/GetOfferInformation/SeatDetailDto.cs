using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FlightManagement_API.Application.Common.Mappings;
using FlightManagement_API.Domain.Entities;

namespace FlightManagement_API.Application.FlightPricing.Queries.GetOfferInformation
{
    public class SeatDetailDto : IMapFrom<SeatDetail>
    {
        public string SeatNumber { get; set; }

        public bool IsAvailable { get; set; }

        public string Class { get; set; }

        public double? SpecialPrice { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<SeatDetail, SeatDetailDto>();
        }
    }
}
