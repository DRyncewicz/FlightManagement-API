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
                    Id = 1,
                    Name = "American Airlines",
                    LogoUrl = "url_to_logo_american",
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
                    Id = 2,
                    Name = "Lufthansa",
                    LogoUrl = "url_to_logo_lufthansa",
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
                        Id = 1,
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
                        Id = 2,
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
                        AirportId = 1,
                        Street = "1 World Way",
                        City = "Los Angeles",
                        State = "CA",
                        Country = "USA",
                        ZipCode = "90045"
                    },
                    new
                    {
                        AirportId = 2,
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
                    Id = 1,
                    Manufacturer = "Boeing",
                    Model = "777",
                    SeatCapacity = 300,
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
                    Id = 2,
                    Manufacturer = "Airbus",
                    Model = "A380",
                    SeatCapacity = 500,
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
                    Id = 1,
                    AircraftId = 1,
                    AirlineId = 1,
                    DepartureAirportId = 1,
                    ArrivalAirportId = 2,
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
                    Id = 2,
                    AircraftId = 2,
                    AirlineId = 2,
                    DepartureAirportId = 2,
                    ArrivalAirportId = 1,
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
                    Id = 1,
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
                    Id = 2,
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
                        Id = 1,
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
                        Id = 2,
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
                        PassengerId = 1,
                        Street = "123 Broadway",
                        City = "New York",
                        State = "NY",
                        Country = "USA",
                        ZipCode = "10007"
                    },
                    new
                    {
                        PassengerId = 2,
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
                    Id = 1,
                    FlightId = 1,
                    PassengerId = 1,
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
                    Id = 2,
                    FlightId = 2,
                    PassengerId = 2,
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
                    Id = 1,
                    AircraftId = 1,
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
                    Id = 2,
                    AircraftId = 1,
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
                    Id = 1,
                    PassengerId = 1,
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
                    Id = 2,
                    PassengerId = 2,
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
