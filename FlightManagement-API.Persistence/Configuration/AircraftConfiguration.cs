using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlightManagement_API.Persistence.Configuration
{
    public class AircraftConfiguration : IEntityTypeConfiguration<Aircraft>
    {
        public void Configure(EntityTypeBuilder<Aircraft> builder)
        {
            builder.Property(p => p.Model).IsRequired();
            builder.Property(p => p.Manufacturer).IsRequired();
            builder.Property(p => p.SeatCapacity).IsRequired();
            builder.Property(p => p.EconomyClassSeats).IsRequired();
            builder.Property(p => p.Range).IsRequired();
            builder.Property(p => p.YearOfManufacture).IsRequired();
        }
    }
}
