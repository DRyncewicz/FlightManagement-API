using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FlightManagement_API.Application.Common.Mappings;
using FlightManagement_API.Domain.Entities;
using MediatR;

namespace FlightManagement_API.Application.Aircrafts.Commands.CreateAircraft
{
    public class CreateAircraftCommand : IRequest<int>, IMapFrom<Aircraft>
    {
        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public int SeatCapacity { get; set; }

        public int BusinessClassSeats { get; set; }

        public int EconomyClassSeats { get; set; }

        public int SeatColumns { get; set; }

        public double Range { get; set; }

        public DateOnly YearOfManufacture { get; set; }

        public DateOnly LastMaintenanceDate { get; set; }

        public int AirlineId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Aircraft, CreateAircraftCommand>().ReverseMap();
        }
    }
}
