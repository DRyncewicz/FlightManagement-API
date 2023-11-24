using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FlightManagement_API.Application.Common.Mappings;
using FlightManagement_API.Domain.Entities;
using MediatR;

namespace FlightManagement_API.Application.Airline.Commands.CreateAirlineContact
{
    public class CreateAirlineContactCommand : IRequest<int>, IMapFrom<AirlineContact>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Position { get; set; }

        public int AirlineId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateAirlineContactCommand, AirlineContact>();
        }
    }
}
