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
    public class LuggageConfiguration : IEntityTypeConfiguration<Luggage>
    {
        public void Configure(EntityTypeBuilder<Luggage> builder)
        {
            builder.Property(p => p.Type).IsRequired();
            builder.Property(p => p.Status).IsRequired();
            builder.Property(p=>p.Dimensions).IsRequired();
        }
    }
}
