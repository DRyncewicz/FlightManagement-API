using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FlightManagement_API.Application.Common.Mappings;
using FlightManagement_API.Domain.ValueObjects;

namespace FlightManagement_API.Application.Booking.Commands
{
    public class AddressDto : IMapFrom<Address>
    {
        public string Street { get; set; }
        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string ZipCode { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AddressDto, Address>();
        }
    }
}
