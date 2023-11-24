using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FlightManagement_API.Application.Common.Interfaces;
using FlightManagement_API.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FlightManagement_API.Application.FlightPricing.Commands.CreateOfferForFlight
{
    public class CreateOfferForFlightCommandHandler(IFlightDbContext flightDbContext, IMapper mapper) : IRequestHandler<CreateOfferForFlightCommand, int>
    {
        public async Task<int> Handle(CreateOfferForFlightCommand request, CancellationToken cancellationToken)
        {
            var aircraft = await flightDbContext.Flights.Where(f => f.Id == request.FlightId)
                .Include(p => p.Aircraft).Select(p => p.Aircraft)
                .FirstOrDefaultAsync(cancellationToken);

            var flightPricing = mapper.Map<Domain.Entities.FlightPricing>(request);
            flightPricing.SeatDetails = FlightSeatsGenerate(aircraft, flightPricing);

            await flightDbContext.FlightPricings.AddAsync(flightPricing, cancellationToken);
            await flightDbContext.SaveChangesAsync(cancellationToken);

            return flightPricing.Id;
        }

        private List<SeatDetail> FlightSeatsGenerate(Aircraft aircraft, Domain.Entities.FlightPricing flightPricing)
        {

            List<SeatDetail> seats = new List<SeatDetail>();
            for (var i = 1; i <= aircraft.SeatCapacity; i++)
            {
                int seatNumber;
                if (i % aircraft.SeatColumns == 0)
                {
                    seatNumber = i / aircraft.SeatColumns;
                }
                else
                {
                    seatNumber = i / aircraft.SeatColumns + 1;
                }

                var seatLetter = GetSeatLetterPart(i % aircraft.SeatColumns == 0 ? aircraft.SeatColumns : i % aircraft.SeatColumns);
                SeatDetail seat = new SeatDetail()
                {
                    FlightPricingId = flightPricing.Id,
                    IsAvailable = true,
                    SpecialPrice = null,
                    SeatNumber = $"{seatNumber}{seatLetter}",
                };
                if (aircraft.BusinessClassSeats >= i)
                {
                    seat.Class = "Business";
                }
                else
                {
                    seat.Class = "Economy";
                }

                seats.Add(seat);
            }

            return seats;
        }

        private char GetSeatLetterPart(int number)
        {
            return (char)('a' + number - 1);
        }
    }
}
