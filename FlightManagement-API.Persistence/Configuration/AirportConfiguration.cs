using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlightManagement_API.Persistence.Configuration
{
    public class AirportConfiguration : IEntityTypeConfiguration<Airport>
    {
        public void Configure(EntityTypeBuilder<Airport> builder)
        {
            builder.
                OwnsOne(a => a.Address, address =>
                {
                    address.WithOwner();
                    address.Property(a => a.Street).HasColumnName("Street");
                    address.Property(a => a.City).HasColumnName("City");
                    address.Property(a => a.State).HasColumnName("State");
                    address.Property(a => a.Country).HasColumnName("Country");
                    address.Property(a => a.ZipCode).HasColumnName("ZipCode").HasMaxLength(10).IsUnicode(false);
                });
            
            builder.Property(p => p.IataCode).HasMaxLength(3).IsRequired().IsFixedLength().IsUnicode(false);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
        }
    }
}
