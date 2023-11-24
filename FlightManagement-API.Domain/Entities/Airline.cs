using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Domain.Common;
using FlightManagement_API.Domain.ValueObjects;

namespace FlightManagement_API.Domain.Entities
{
    public class Airline : AuditableEntity
    {
        public string Name { get; set; }

        public string LogoUrl { get; set; }

        public string CeoFirstName { get; set; }

        public string CeoLastName { get; set;}

        public string SiteUrl { get; set; }

        public ICollection<AirlineContact> Contacts { get; set; }

        ICollection<Aircraft> Aircrafts { get; set; }
    }
}

