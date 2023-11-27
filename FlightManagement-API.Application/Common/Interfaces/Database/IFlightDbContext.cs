using FlightManagement_API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FlightManagement_API.Application.Common.Interfaces.Database
{
    public interface IFlightDbContext
    {
        DbSet<Aircraft> Aircrafts { get; set; }

        DbSet<Domain.Entities.Airline> Airlines { get; set; }

        DbSet<AirlineContact> AirlineContacts { get; set; }

        DbSet<Airport> Airports { get; set; }

        DbSet<Domain.Entities.FlightPricing> FlightPricings { get; set; }

        DbSet<SeatDetail> SeatDetails { get; set; }

        DbSet<Amenity> Amenities { get; set; }

        DbSet<Domain.Entities.Booking> Bookings { get; set; }

        DbSet<Flight> Flights { get; set; }

        DbSet<FlightDetail> FlightDetails { get; set; }

        DbSet<Luggage> Luggages { get; set; }

        DbSet<Passenger> Passengers { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
