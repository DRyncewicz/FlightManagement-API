using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FlightManagement_API.Application.Common.Mappings;
using FlightManagement_API.Domain.Entities;
using MediatR;

namespace FlightManagement_API.Application.FlightPricing.Commands.CreateOfferForFlight
{
    public class CreateOfferForFlightCommand : IRequest<int>, IMapFrom<Domain.Entities.FlightPricing>
    {
        public int FlightId { get; set; }

        public double EconomyPrice { get; set; }

        public double BusinessPrice { get; set; }

        public int AvailableEconomySeats { get; set; }

        public int AvailableBusinessSeats { get; set; }

        public DateTime LastUpdated { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateOfferForFlightCommand, Domain.Entities.FlightPricing>();
        }
    }
}
