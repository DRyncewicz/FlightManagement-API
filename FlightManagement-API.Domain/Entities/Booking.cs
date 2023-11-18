using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Domain.Common;

namespace FlightManagement_API.Domain.Entities
{
    public class Booking : AuditableEntity
    {
        public int FlightId { get; set; }

        public Flight Flight { get; set; }

        public string Status { get; set; }

        public DateTime ReservationDate { get; set; }

        public int PassengerId { get; set; }

        public Passenger Passenger { get; set; }

        public double Price { get; set; }


    }
}
