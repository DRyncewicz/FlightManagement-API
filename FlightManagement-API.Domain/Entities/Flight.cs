﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Domain.Common;

namespace FlightManagement_API.Domain.Entities
{
    public class Flight : AuditableEntity
    {
        public string FlightNumber { get; set; }

        public int DepartureAirportId { get; set; }

        public int ArrivalAirportId { get; set; }

        public Airport ArrivalAirport { get; set; }

        public Airport DepartureAirport { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }

        public int AirlineId { get; set; }

        public Airline Airline { get; set; }

        public int AircraftId { get; set; }

        public Aircraft Aircraft { get; set; }

        public string status { get; set; }

        public FlightDetail FlightDetail{ get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}