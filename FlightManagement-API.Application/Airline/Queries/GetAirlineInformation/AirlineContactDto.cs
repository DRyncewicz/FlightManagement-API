using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FlightManagement_API.Application.Common.Mappings;
using FlightManagement_API.Domain.Entities;

namespace FlightManagement_API.Application.Airline.Queries.GetAirlineInformation
{
    public class AirlineContactDto : IMapFrom<AirlineContact>
    {
        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Position { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AirlineContact, AirlineContactDto>()
                .ForMember(m => m.FullName, map => map.MapFrom(src => src.FirstName + " " + src.LastName));
        }
    }
}
