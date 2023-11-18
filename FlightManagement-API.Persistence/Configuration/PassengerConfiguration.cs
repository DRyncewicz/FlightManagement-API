using FlightManagement_API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlightManagement_API.Persistence.Configuration
{
    internal class PassengerConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.
                OwnsOne(a => a.Address, address =>
                {
                    address.WithOwner();
                    address.Property(a => a.Street).HasColumnName("Street");
                    address.Property(a => a.City).HasColumnName("City");
                    address.Property(a => a.State).HasColumnName("State");
                    address.Property(a => a.Country).HasColumnName("Country");
                    address.Property(a => a.ZipCode).HasColumnName("ZipCode").HasMaxLength(10).IsUnicode(false); ;
                });

            builder.Property(p => p.Email).IsRequired().HasMaxLength(255).IsUnicode(false);
            builder.Property(p => p.PhoneNumber).IsRequired().HasMaxLength(20).IsUnicode(false);
            builder.Property(p => p.FirstName).IsRequired();
            builder.Property(p => p.LastName).IsRequired();
        }
    }
}
