using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace FlightManagement_API.Application.Airline.Commands.CreateAirline
{
    public class CreateAirlineCommandValidator : AbstractValidator<CreateAirlineCommand>
    {
        public CreateAirlineCommandValidator()
        {
            RuleFor(p=>p.SiteUrl).Must(BeAValidUrl)
                .WithMessage("The string must be a valid URL.");
            RuleFor(p => p.LogoUrl).Must(BeAValidUrl)
                .WithMessage("The string must be a valid URL.");
            RuleFor(p => p.Name).NotEmpty();
        }

        private bool BeAValidUrl(string url)
        {
            return Uri.IsWellFormedUriString(url, UriKind.Absolute);
        }
    }
}
