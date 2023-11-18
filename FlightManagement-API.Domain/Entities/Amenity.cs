using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Domain.Common;

namespace FlightManagement_API.Domain.Entities
{
    public class Amenity : AuditableEntity
    {
        public string Name { get; set; }

        public int AircraftId { get; set; }

        public Aircraft Aircraft { get; set; }
    }
}
