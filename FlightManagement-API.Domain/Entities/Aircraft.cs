using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Domain.Common;

namespace FlightManagement_API.Domain.Entities
{
    public class Aircraft :  AuditableEntity
    {
        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public int SeatCapacity { get; set; }

        public int BusinessClassSeats { get; set; }

        public int EconomyClassSeats { get; set; }

        public double Range { get; set; }

        public DateOnly YearOfManufacture { get; set; }

        public DateOnly LastMaintenanceDate { get; set; }

        public ICollection<Flight> Flights { get; set; }

        public ICollection<Amenity> Amenities { get; set; }
    }
}
