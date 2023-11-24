using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FlightManagement_API.Application.Common.Mappings;
using MediatR;

namespace FlightManagement_API.Application.Airline.Commands.CreateAirline
{
    public class CreateAirlineCommand : IRequest<int>, IMapFrom<Domain.Entities.Airline>
    {
        public string Name { get; set; }

        public string LogoUrl { get; set; }

        public string CeoFirstName { get; set; }

        public string CeoLastName { get; set; }

        public string SiteUrl { get; set; }


        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Airline, CreateAirlineCommand>().ReverseMap();
        }
    }
}
