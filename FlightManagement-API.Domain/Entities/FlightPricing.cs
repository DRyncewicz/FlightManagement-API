using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Domain.Common;

namespace FlightManagement_API.Domain.Entities
{
    public class FlightPricing : AuditableEntity
    {
        public int FlightId { get; set; }

        public double EconomyPrice { get; set; }

        public double BusinessPrice { get; set; }

        public int AvailableEconomySeats { get; set; }

        public int AvailableBusinessSeats { get; set; }

        public DateTime LastUpdated { get; set; }

        public Flight Flight { get; set; }

        public ICollection<SeatDetail> SeatDetails { get; set; }
    }
}
