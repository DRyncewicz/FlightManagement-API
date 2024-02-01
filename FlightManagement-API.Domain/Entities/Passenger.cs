using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Domain.Common;
using FlightManagement_API.Domain.ValueObjects;

namespace FlightManagement_API.Domain.Entities
{
    public class Passenger : AuditableEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public Address Address { get; set; }

        public ICollection<Luggage> Luggages { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
