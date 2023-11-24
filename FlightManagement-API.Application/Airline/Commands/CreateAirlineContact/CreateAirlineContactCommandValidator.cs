using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using FluentValidation;

namespace FlightManagement_API.Application.Airline.Commands.CreateAirlineContact
{
    public class CreateAirlineContactCommandValidator : AbstractValidator<CreateAirlineContactCommand>
    {
        public CreateAirlineContactCommandValidator()
        {
            RuleFor(ac => ac.Email).NotEmpty()
                .EmailAddress()
                .WithMessage("Please provide a valid email address.");
            RuleFor(ac => ac.PhoneNumber).NotEmpty()
                .Matches(new Regex(@"^\+?[1-9]\d{1,14}$"))
                .WithMessage("Please provide a valid phone number.");
        }
    }
}
