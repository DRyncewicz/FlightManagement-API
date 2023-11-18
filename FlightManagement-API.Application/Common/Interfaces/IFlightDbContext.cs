﻿using FlightManagement_API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FlightManagement_API.Application.Common.Interfaces
{
    public interface IFlightDbContext
    {
        DbSet<Aircraft> Aircrafts { get; set; }

        DbSet<Airline> Airlines { get; set; }

        DbSet<Airport> Airports { get; set; }

        DbSet<Amenity> Amenities { get; set; }

        DbSet<Booking> Bookings { get; set; }

        DbSet<Flight> Flights { get; set; }

        DbSet<FlightDetail> FlightDetails { get; set; }

        DbSet<Luggage> Luggages { get; set; }

        DbSet<Passenger> Passengers { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}