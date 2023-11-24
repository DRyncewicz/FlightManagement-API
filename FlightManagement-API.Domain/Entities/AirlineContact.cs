using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Domain.Common;

namespace FlightManagement_API.Domain.Entities
{
    public class AirlineContact : AuditableEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Position { get; set; }

        public int AirlineId { get; set; }

        public Airline Airline { get; set; }
    }
}
