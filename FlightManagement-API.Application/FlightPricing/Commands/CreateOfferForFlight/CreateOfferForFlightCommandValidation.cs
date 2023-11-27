using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Application.Common.Interfaces.Database;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace FlightManagement_API.Application.FlightPricing.Commands.CreateOfferForFlight
{
    public class CreateOfferForFlightCommandValidation : AbstractValidator<CreateOfferForFlightCommand>
    {
        private readonly IFlightDbContext _flightDbContext;

        public CreateOfferForFlightCommandValidation(IFlightDbContext flightDbContext)
        {
            _flightDbContext = flightDbContext;

            RuleFor(x => x.AvailableBusinessSeats)
                .Must((command, availableBusinessSeats) => BeLessThanOrEqualToBusinessSeats(command.FlightId, availableBusinessSeats))
                .WithMessage("Available business seats cannot exceed the total number of business seats in the aircraft.");

            RuleFor(x => x.AvailableEconomySeats)
                .Must((command, availableEconomySeats) => BeLessThanOrEqualToBusinessSeats(command.FlightId, availableEconomySeats))
                .WithMessage("Available economy seats cannot exceed the total number of economy seats in the aircraft.");
        }

        private bool BeLessThanOrEqualToBusinessSeats(int flightId, int availableBusinessSeats)
        {
            var flight =  _flightDbContext.Flights
                .Include(a => a.Aircraft)
                .FirstOrDefault(a => a.Id == flightId);

            if (flight == null) return false;


            var totalBusinessSeats = flight.Aircraft.BusinessClassSeats;
            return availableBusinessSeats <= totalBusinessSeats;
        }

        private bool BeLessThanOrEqualToEconomySeats(int flightId, int availableEconomySeats)
        {
            var flight = _flightDbContext.Flights
                .Include(a => a.Aircraft)
                .FirstOrDefault(a => a.Id == flightId);

            if (flight == null) return false;


            var totalBusinessSeats = flight.Aircraft.BusinessClassSeats;
            return availableEconomySeats <= totalBusinessSeats;
        }
    }
}
