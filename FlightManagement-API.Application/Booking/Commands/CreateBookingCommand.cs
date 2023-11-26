using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FlightManagement_API.Application.Common.Mappings;
using FlightManagement_API.Domain.Entities;
using FlightManagement_API.Domain.ValueObjects;
using MediatR;

namespace FlightManagement_API.Application.Booking.Commands
{
    public class CreateBookingCommand : IRequest<int>, IMapFrom<Domain.Entities.Booking>
    {
        public int FlightId { get; set; }

        public string BookingStatus { get; set; }

        public DateTime ReservationDate { get; set; }

        public double Price { get; set; }

        public int? PassengerId { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public AddressDto? Address { get; set; }

        public string Dimensions { get; set; }

        public string LuggageStatus { get; set; }

        public string Type { get; set; }

        public double Weight { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateBookingCommand, Domain.Entities.Booking>()
                .ForMember(p => p.Status, map => map.MapFrom(src => src.BookingStatus));

            if(!PassengerId.HasValue)
            {
                profile.CreateMap<CreateBookingCommand, Passenger>()
                    .ForMember(p => p.Address, map => map.MapFrom(src => new Address(
                        src.Address.Street,
                        src.Address.City,
                        src.Address.State,
                        src.Address.Country,
                        src.Address.ZipCode
                    )));
            }

            profile.CreateMap<CreateBookingCommand, Luggage>()
                .ForMember(p => p.Status, map => map.MapFrom(src => src.LuggageStatus));
        }
    }
}
