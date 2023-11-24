using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FlightManagement_API.Application.Common.Mappings;

namespace FlightManagement_API.Application.Airline.Queries.GetAirlineInformation
{
    public class AirlineInformationVm : IMapFrom<Domain.Entities.Airline>
    {
        public string Name { get; set; }

        public string LogoUrl { get; set; }

        public string CeoFullName { get; set; }

        public string SiteUrl { get; set; }

        public List<AirlineContactDto> Contacts { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Airline, AirlineInformationVm>()
                .ForMember(m => m.CeoFullName, map => map.MapFrom(src => src.CeoFirstName + " " + src.CeoLastName));
        }
    }
}
