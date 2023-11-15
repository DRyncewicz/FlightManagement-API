using Microsoft.EntityFrameworkCore;
using FlightManagement_API.Domain.Common;
using FlightManagement_API.Domain.Entities;

namespace FlightManagement_API.Persistence
{
    public class FlightDbContext : DbContext
    {
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

            modelBuilder.Entity<Airport>(entity =>
            {
                entity.OwnsOne(a => a.Address, address =>
                {
                    address.WithOwner();
                    address.Property(a => a.Street).HasColumnName("Street");
                    address.Property(a => a.City).HasColumnName("City");
                    address.Property(a => a.State).HasColumnName("State");
                    address.Property(a => a.Country).HasColumnName("Country");
                    address.Property(a => a.ZipCode).HasColumnName("ZipCode");
                });
            });

            modelBuilder.Entity<Passenger>(entity =>
            {
                entity.OwnsOne(p => p.Address, address =>
                {
                    address.WithOwner();
                    address.Property(a => a.Street).HasColumnName("Street");
                    address.Property(a => a.City).HasColumnName("City");
                    address.Property(a => a.State).HasColumnName("State");
                    address.Property(a => a.Country).HasColumnName("Country");
                    address.Property(a => a.ZipCode).HasColumnName("ZipCode");
                });
            });
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = string.Empty;
                        entry.Entity.Created = DateTime.Now;
                        entry.Entity.StatusId = 1;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = string.Empty;
                        entry.Entity.Modified = DateTime.Now;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.ModifiedBy = string.Empty;
                        entry.Entity.Modified = DateTime.Now;
                        entry.Entity.Inactivated = DateTime.Now;
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
