using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AutoMapper;
using FlightManagement_API.Application.Common.Mappings;
using FlightManagement_API.Domain.Entities;

namespace FlightManagement_API.Application.Flights.Queries.GetFlightInformation
{
    public class FlightInformationVm : IMapFrom<Flight>
    {
        public string FlightNumber { get; set; }

        public string DepartureIataCode { get; set; }

        public string ArrivalIataCode { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }

        public string AirlineName { get; set; }

        public string AirlineLogo { get; set; }

        public string AircraftInfo { get; set; }

        public string status { get; set; }

        public string Gate { get; set; }

        public DateTime GateTime { get; set; }

        public string Terminal { get; set; }

        public string Stand { get; set; }

        public bool Aerobridge { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Flight, FlightInformationVm>()
                .ForMember(d => d.Gate, map => map.MapFrom(src => src.FlightDetail.Gate))
                .ForMember(d => d.GateTime, map => map.MapFrom(src => src.FlightDetail.GateTime))
                .ForMember(d => d.Terminal, map => map.MapFrom(src => src.FlightDetail.Terminal))
                .ForMember(d => d.Stand, map => map.MapFrom(src => src.FlightDetail.Stand))
                .ForMember(d => d.Aerobridge, map => map.MapFrom(src => src.FlightDetail.Aerobridge))
                .ForMember(d => d.DepartureIataCode, map => map.MapFrom(src => src.DepartureAirport.IataCode))
                .ForMember(d => d.ArrivalIataCode, map => map.MapFrom(src => src.ArrivalAirport.IataCode))
                .ForMember(d => d.AirlineName, map => map.MapFrom(src => src.Airline.Name))
                .ForMember(d => d.AirlineLogo, map => map.MapFrom(src => src.Airline.LogoUrl))
                .ForMember(d => d.AircraftInfo, map => map.MapFrom(src => src.Aircraft.Manufacturer + " " + src.Aircraft.Model));
        }
    }
}
