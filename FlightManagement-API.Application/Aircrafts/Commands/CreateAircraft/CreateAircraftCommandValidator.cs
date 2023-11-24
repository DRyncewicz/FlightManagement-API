using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Application.Common.Interfaces;
using FluentValidation;

namespace FlightManagement_API.Application.Aircrafts.Commands.CreateAircraft
{
    public class CreateAircraftCommandValidator : AbstractValidator<CreateAircraftCommand> 
    {
        public CreateAircraftCommandValidator(IDateTime dateTime)
        {
            RuleFor(a => a.Range).NotEmpty().LessThan(20000);
            RuleFor(a => a.Manufacturer).NotEmpty();
            RuleFor(a => a.EconomyClassSeats).NotEmpty();
            RuleFor(a => a.SeatCapacity).Must((model, seatCapacity) =>
                seatCapacity == (model.BusinessClassSeats + model.EconomyClassSeats))
                .WithMessage("Sum of all seats must be equal to seat capacity");
            RuleFor(a => a.YearOfManufacture).NotEmpty();
            RuleFor(a => a.LastMaintenanceDate).Must(lastDate => DateOnly.FromDateTime(DateTime.Now.AddYears(-1)) < lastDate)
                .WithMessage("Last inspection for newly registered aircrafts must not be more than 3 months ago");
        }
    }
}
