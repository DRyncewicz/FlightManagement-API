using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FlightManagement_API.Application.Common.Mappings;
using FlightManagement_API.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FlightManagement_API.Application.Aircrafts.Queries.GetAircraftInformation
{
    public class AircraftInformationVm :IMapFrom<Aircraft>
    {
        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public int SeatCapacity { get; set; }

        public string Owner { get; set; }

        public int BusinessClassSeats { get; set; }

        public int EconomyClassSeats { get; set; }

        public int SeatColumns { get; set; }

        public double Range { get; set; }

        public DateOnly YearOfManufacture { get; set; }

        public DateOnly LastMaintenanceDate { get; set; }

        public List<string> Amenities { get; set; }    

        public List<FlightsForListDto> Flights { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Aircraft, AircraftInformationVm>()
                .ForMember(d => d.Amenities, map => map.MapFrom(src => src.Amenities.Select(a => a.Name)))
                .ForMember(d => d.Owner, map => map.MapFrom(src => src.Airline.Name));
        }
    }
}
