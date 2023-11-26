using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FlightManagement_API.Application.Common.Mappings;
using FlightManagement_API.Domain.Entities;

namespace FlightManagement_API.Application.Flights.Queries.GetFilteredFlights
{
    public class FilteredFlightDto : IMapFrom<Flight>
    {
        public string DepartureAirportIata { get; set; }

        public string ArrivalAirportIata { get; set; }
        
        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }

        public double Price { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Flight, FilteredFlightDto>()
                .ForMember(t => t.DepartureAirportIata, map => map.MapFrom(src => src.DepartureAirport.IataCode))
                .ForMember(t => t.ArrivalAirportIata, map => map.MapFrom(src => src.ArrivalAirport.IataCode))
                .ForMember(t => t.Price, map => map.MapFrom(src => src.FlightPricing.EconomyPrice));
        }
    }
}
