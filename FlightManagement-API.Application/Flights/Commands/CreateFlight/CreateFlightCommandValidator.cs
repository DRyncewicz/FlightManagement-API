using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FlightManagement_API.Application.Flights.Commands.CreateFlight
{
    public class CreateFlightCommandValidator : AbstractValidator<CreateFlightCommand>
    {
        public CreateFlightCommandValidator(IDateTime dateTime)
        {
            RuleFor(flight => flight.FlightNumber)
                .NotEmpty().WithMessage("Flight number is required.")
                .Matches(@"^[A-Za-z]{2,3}\d{1,4}$").WithMessage("Invalid flight number format.");

            RuleFor(flight => flight.DepartureTime)
                .GreaterThan(dateTime.Now).WithMessage("Flight date must be in the future.");

            RuleFor(flight => flight.FlightDistance)
                .GreaterThan(150);

            RuleFor(flight => flight.GateTime)
                .GreaterThan(dateTime.Now).WithMessage("Gate date must be in the future.");

            RuleFor(flight => flight.ArrivalTime)
                .GreaterThan(flight => flight.DepartureTime).WithMessage("Arrival time must be after departure.");

        }
    }
}
