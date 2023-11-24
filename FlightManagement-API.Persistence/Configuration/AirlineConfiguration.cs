using FlightManagement_API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlightManagement_API.Persistence.Configuration
{
    public class AirlineConfiguration : IEntityTypeConfiguration<Airline>
    {
        public void Configure(EntityTypeBuilder<Airline> builder)
        {
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.CeoFirstName).IsRequired();
            builder.Property(p => p.CeoLastName).IsRequired();
            builder.Property(p => p.SiteUrl).IsRequired();
        }
    }
}
