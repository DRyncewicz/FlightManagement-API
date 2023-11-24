using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FlightManagement_API.Application.Common.Mappings;
using FlightManagement_API.Domain.Entities;

namespace FlightManagement_API.Application.Aircrafts.Queries.GetAircraftInformation
{
    public class FlightsForListDto : IMapFrom<Flight>
    {
        public string FlightNumber { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }

        public string DepartureIataCode { get; set; }

        public string ArrivalIataCode { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Flight, FlightsForListDto>()
                .ForMember(d => d.DepartureIataCode, map => map.MapFrom(src => src.DepartureAirport.IataCode))
                .ForMember(d => d.ArrivalIataCode, map => map.MapFrom(src => src.ArrivalAirport.IataCode));
        }
    }
}
