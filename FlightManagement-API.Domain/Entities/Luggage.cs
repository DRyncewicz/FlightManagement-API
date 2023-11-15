using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Domain.Common;

namespace FlightManagement_API.Domain.Entities
{
    public class Luggage : AuditableEntity
    {
        public int PassengerId { get; set; }

        public Passenger Passenger { get; set; }

        public string Dimensions { get; set; }

        public string Status { get; set; }

        public string Type { get; set; }

        public double Weight { get; set; }
    }
}
