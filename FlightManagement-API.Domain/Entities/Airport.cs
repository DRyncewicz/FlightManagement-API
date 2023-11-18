using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Domain.Common;
using FlightManagement_API.Domain.ValueObjects;

namespace FlightManagement_API.Domain.Entities
{
    public class Airport : AuditableEntity
    {
        public string Name { get; set; }

        public Address Address { get; set; }

        public string IataCode { get; set; }

        public ICollection<Flight> DepartureFlights { get; set; }

        public ICollection<Flight> ArrivalFlights { get; set; }
    }
}
