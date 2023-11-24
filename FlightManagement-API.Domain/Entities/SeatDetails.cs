using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Domain.Common;

namespace FlightManagement_API.Domain.Entities
{
    public class SeatDetail : AuditableEntity
    {
        public int FlightPricingId { get; set; }

        public string SeatNumber { get; set; }

        public bool IsAvailable { get; set; }

        public string Class { get; set; }

        public double? SpecialPrice { get; set; }

        public FlightPricing FlightPricing { get; set; }
    }
}
