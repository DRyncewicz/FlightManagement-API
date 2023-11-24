using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlightManagement_API.Persistence.Configuration
{
    public class AirlineContactConfiguration : IEntityTypeConfiguration<AirlineContact>
    {
        public void Configure(EntityTypeBuilder<AirlineContact> builder)
        {
            builder.Property(p => p.Email).IsRequired().HasMaxLength(254);
            builder.Property(p => p.FirstName).IsRequired();
            builder.Property(p => p.LastName).IsRequired();
            builder.Property(p => p.PhoneNumber).IsRequired().HasMaxLength(15);
            builder.Property(p => p.Position).IsRequired();
        }
    }
}
