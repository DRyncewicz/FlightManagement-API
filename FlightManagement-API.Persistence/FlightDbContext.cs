using System.Reflection;
using FlightManagement_API.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using FlightManagement_API.Domain.Common;
using FlightManagement_API.Domain.Entities;

namespace FlightManagement_API.Persistence
{
    public class FlightDbContext: DbContext
    {
        private readonly IDateTime _dateTime;
        public DbSet<Aircraft> Aircrafts { get; set; }

        public DbSet<Airline> Airlines { get; set; }

        public DbSet<Airport> Airports { get; set; }

        public DbSet<Amenity> Amenities { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Flight> Flights { get; set; }

        public DbSet<FlightDetail> FlightDetails { get; set; }

        public DbSet<Luggage> Luggages { get; set; }

        public DbSet<Passenger> Passengers { get; set; }

        public FlightDbContext(DbContextOptions<FlightDbContext> options) : base(options)
        {

        }

        public FlightDbContext(DbContextOptions<FlightDbContext> options, IDateTime dateTime) : base(options)
        {
            _dateTime = dateTime;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedData();
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<FlightDetail>()
                .HasKey(fd => fd.Id);

            modelBuilder.Entity<FlightDetail>()
                .HasOne(fd => fd.Flight)
                .WithOne(f => f.FlightDetail)
                .HasForeignKey<FlightDetail>(fd => fd.Id);


            modelBuilder.Entity<Airport>()
                .HasMany(a => a.DepartureFlights)
                .WithOne(f => f.DepartureAirport)
                .HasForeignKey(f => f.DepartureAirportId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Airport>()
                .HasMany(a => a.ArrivalFlights)
                .WithOne(f => f.ArrivalAirport)
                .HasForeignKey(f => f.ArrivalAirportId)
                .OnDelete(DeleteBehavior.Restrict);

        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = string.Empty;
                        entry.Entity.Created = _dateTime.Now;
                        entry.Entity.StatusId = 1;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = string.Empty;
                        entry.Entity.Modified = _dateTime.Now;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.ModifiedBy = string.Empty;
                        entry.Entity.Modified = _dateTime.Now;
                        entry.Entity.Inactivated = _dateTime.Now;
                        entry.Entity.InactivatedBy = string.Empty;
                        entry.Entity.StatusId = 0;
                        entry.State = EntityState.Modified;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
