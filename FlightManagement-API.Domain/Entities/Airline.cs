using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Domain.Common;

namespace FlightManagement_API.Domain.Entities
{
    public class Airline : AuditableEntity
    {
        public string Name { get; set; }

        public string LogoUrl { get; set; }

        ICollection<Flight> Flights { get; set; }
    }
}
