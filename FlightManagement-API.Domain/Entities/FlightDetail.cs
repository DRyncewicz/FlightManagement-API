using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Domain.Common;

namespace FlightManagement_API.Domain.Entities
{
    public class FlightDetail : AuditableEntity
    {
        public Flight Flight { get; set; }

        public string Gate { get; set; }

        public string Terminal { get; set; }

        public string Stand { get; set; }

        public string BaggageCarousel { get; set; }

        public int CheckInCounter { get; set; }

        public string BoardingStatus { get; set; }

        public bool Aerobridge { get; set; }

        public DateTime GateTime { get; set; }

        public double FLightDistance { get; set; }
    }
}
