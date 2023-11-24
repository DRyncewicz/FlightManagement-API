using FlightManagement_API.Application.Common.Interfaces;
using FlightManagement_API.Domain.Entities;
using FlightManagement_API.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace FlightManagement_API.Persistence
{
    public static class Seed
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Airline>().HasData(
                new Airline
                {
                    Id = 11,
                    Name = "American Airlines",
                    LogoUrl = "url_to_logo_american",
                    CeoFirstName = "Janusz",
                    CeoLastName = "Knot",
                    SiteUrl = "https://www.aa.com",
                    Created = DateTime.Now,
                    CreatedBy = "admin",
                    Inactivated = null,
                    InactivatedBy = "",
                    Modified = null,
                    ModifiedBy = "",
                    StatusId = 1
                },
                new Airline
                {
                    Id = 12,
                    Name = "Lufthansa",
                    LogoUrl = "url_to_logo_lufthansa",
                    CeoFirstName = "Helmuth",
                    CeoLastName = "Riddle",
                    SiteUrl = "https://www.lufthansa.com",
                    Created = DateTime.Now,
                    CreatedBy = "admin",
                    Inactivated = null,
                    InactivatedBy = "",
                    Modified = null,
                    ModifiedBy = "",
                    StatusId = 1

                }
            );

            modelBuilder.Entity<Airport>(p =>
            {
                p.HasData(new
                    {
                        Id = 11,
                        Name = "Los Angeles International Airport",
                        IataCode = "LAX",
                        Created = DateTime.Now,
                        CreatedBy = "admin",
                        Inactivated = (DateTime?)null,
                        InactivatedBy = "",
                        Modified = (DateTime?)null,
                        ModifiedBy = "",
                        StatusId = 1
                },
                    new
                    {
                        Id = 12,
                        Name = "Frankfurt Airport",
                        IataCode = "FRA",
                        Created = DateTime.Now,
                        CreatedBy = "admin",
                        Inactivated = (DateTime?)null,
                        InactivatedBy = "",
                        Modified = (DateTime?)null,
                        ModifiedBy = "",
                        StatusId = 1
                    });

                p.OwnsOne(a => a.Address).HasData(new
                    {
                        AirportId = 11,
                        Street = "1 World Way",
                        City = "Los Angeles",
                        State = "CA",
                        Country = "USA",
                        ZipCode = "90045"
                    },
                    new
                    {
                        AirportId = 12,
                        Street = "60547 Frankfurt",
                        City = "Frankfurt",
                        State = "Hesse",
                        Country = "Germany",
                        ZipCode = "60547"
                    });
            });

            modelBuilder.Entity<Aircraft>().HasData(
                new Aircraft
                {
                    Id = 11,
                    Manufacturer = "Boeing",
                    Model = "777",
                    SeatCapacity = 300,
                    BusinessClassSeats = 100,
                    EconomyClassSeats = 200,
                    SeatColumns = 6,
                    Range = 10820,
                    AirlineId = 11,
                    Created = DateTime.Now,
                    CreatedBy = "admin",
                    Inactivated = null,
                    InactivatedBy = "",
                    Modified = null,
                    ModifiedBy = "",
                    StatusId = 1
                },
                new Aircraft
                {
                    Id = 12,
                    Manufacturer = "Airbus",
                    Model = "A380",
                    SeatCapacity = 500,
                    BusinessClassSeats = 160,
                    EconomyClassSeats = 340,
                    SeatColumns = 10,
                    Range = 15200,
                    AirlineId = 11,
                    Created = DateTime.Now,
                    CreatedBy = "admin",
                    Inactivated = null,
                    InactivatedBy = "",
                    Modified = null,
                    ModifiedBy = "",
                    StatusId = 1
                }
            );

            modelBuilder.Entity<Flight>().HasData(
                new Flight
                {
                    Id = 11,
                    AircraftId = 11,
                    DepartureAirportId = 11,
                    ArrivalAirportId = 12,
                    DepartureTime = DateTime.Now.AddHours(3),
                    ArrivalTime = DateTime.Now.AddHours(11),
                    FlightNumber = "AA100",
                    Status = "Active",
                    Created = DateTime.Now,
                    CreatedBy = "admin",
                    Inactivated = null,
                    InactivatedBy = "",
                    Modified = null,
                    ModifiedBy = "",
                    StatusId = 1
                },
                new Flight
                {
                    Id = 12,
                    AircraftId = 12,
                    DepartureAirportId = 12,
                    ArrivalAirportId = 11,
                    DepartureTime = DateTime.Now.AddHours(12),
                    ArrivalTime = DateTime.Now.AddHours(20),
                    FlightNumber = "LH205",
                    Status = "Active",
                    Created = DateTime.Now,
                    CreatedBy = "admin",
                    Inactivated = null,
                    InactivatedBy = "",
                    Modified = null,
                    ModifiedBy = "",
                    StatusId = 1
                }
            );

            modelBuilder.Entity<FlightDetail>().HasData(
                new FlightDetail
                {
                    Id = 11,
                    Aerobridge = true,
                    BaggageCarousel = "Carousel 5",
                    BoardingStatus = "On Time",
                    CheckInCounter = 22,
                    Gate = "G5",
                    GateTime = DateTime.Now.AddHours(2.5),
                    FlightDistance = 2500,
                    Terminal = "Terminal 1",
                    Stand = "Stand 3A",
                    Created = DateTime.Now,
                    CreatedBy = "admin",
                    Inactivated = null,
                    InactivatedBy = "",
                    Modified = null,
                    ModifiedBy = "",
                    StatusId = 1
                },
                new FlightDetail
                {
                    Id = 12,
                    Aerobridge = false,
                    BaggageCarousel = "Carousel 3",
                    BoardingStatus = "Delayed",
                    CheckInCounter = 18,
                    Gate = "G10",
                    GateTime = DateTime.Now.AddHours(11.5),
                    FlightDistance = 3200,
                    Terminal = "Terminal 2",
                    Stand = "Stand 4B",
                    Created = DateTime.Now,
                    CreatedBy = "admin",
                    Inactivated = null,
                    InactivatedBy = "",
                    Modified = null,
                    ModifiedBy = "",
                    StatusId = 1
                }
            );

            modelBuilder.Entity<Passenger>(p =>
            {
                p.HasData(new
                    {
                        Id = 11,
                        FirstName = "John",
                        LastName = "Doe",
                        Email = "johndoe@example.com",
                        PhoneNumber = "123456789",
                        Created = DateTime.Now,
                        CreatedBy = "admin",
                        Inactivated = (DateTime?)null,
                        InactivatedBy = "",
                        Modified = (DateTime?)null,
                        ModifiedBy = "",
                        StatusId = 1
                    },
                    new
                    {
                        Id = 12,
                        FirstName = "Jane",
                        LastName = "Smith",
                        Email = "janesmith@example.com",
                        PhoneNumber = "987654321",
                        Created = DateTime.Now,
                        CreatedBy = "admin",
                        Inactivated = (DateTime?)null,
                        InactivatedBy = "",
                        Modified = (DateTime?)null,
                        ModifiedBy = "",
                        StatusId = 1
                    });

                p.OwnsOne(a => a.Address).HasData(new
                    {
                        PassengerId = 11,
                        Street = "123 Broadway",
                        City = "New York",
                        State = "NY",
                        Country = "USA",
                        ZipCode = "10007"
                    },
                    new
                    {
                        PassengerId = 12,
                        Street = "Alexanderplatz 1",
                        City = "Berlin",
                        State = "Berlin",
                        Country = "Germany",
                        ZipCode = "10178"
                    });
            });

            modelBuilder.Entity<Booking>().HasData(
                new Booking
                {
                    Id = 11,
                    FlightId = 11,
                    PassengerId = 11,
                    Price = 500.00,
                    ReservationDate = DateTime.Now,
                    Status = "Confirmed",
                    Created = DateTime.Now,
                    CreatedBy = "admin",
                    Inactivated = null,
                    InactivatedBy = "",
                    Modified = null,
                    ModifiedBy = "",
                    StatusId = 1
                },
                new Booking
                {
                    Id = 12,
                    FlightId = 12,
                    PassengerId = 12,
                    Price = 750.00,
                    ReservationDate = DateTime.Now,
                    Status = "Confirmed",
                    Created = DateTime.Now,
                    CreatedBy = "admin",
                    Inactivated = null,
                    InactivatedBy = "",
                    Modified = null,
                    ModifiedBy = "",
                    StatusId = 1
                }
            );

            modelBuilder.Entity<Amenity>().HasData(
                new Amenity
                {
                    Id = 11,
                    AircraftId = 11,
                    Name = "Wi-Fi",
                    Created = DateTime.Now,
                    CreatedBy = "admin",
                    Inactivated = null,
                    InactivatedBy = "",
                    Modified = null,
                    ModifiedBy = "",
                    StatusId = 1
                },
                new Amenity
                {
                    Id = 12,
                    AircraftId = 11,
                    Name = "Extra Legroom",
                    Created = DateTime.Now,
                    CreatedBy = "admin",
                    Inactivated = null,
                    InactivatedBy = "",
                    Modified = null,
                    ModifiedBy = "",
                    StatusId = 1
                }
            );

            modelBuilder.Entity<Luggage>().HasData(
                new Luggage
                {
                    Id = 11,
                    PassengerId = 11,
                    Dimensions = "22x14x9 inches",
                    Weight = 15.5,
                    Type = "Carry-on",
                    Status = "Checked",
                    Created = DateTime.Now,
                    CreatedBy = "admin",
                    Inactivated = null,
                    InactivatedBy = "",
                    Modified = null,
                    ModifiedBy = "",
                    StatusId = 1
                },
                new Luggage
                {
                    Id = 12,
                    PassengerId = 12,
                    Dimensions = "24x16x10 inches",
                    Weight = 20.0,
                    Type = "Checked",
                    Status = "Checked",
                    Created = DateTime.Now,
                    CreatedBy = "admin",
                    Inactivated = null,
                    InactivatedBy = "",
                    Modified = null,
                    ModifiedBy = "",
                    StatusId = 1
                }
            );
        }
    }
}
