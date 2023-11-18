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
    public class FlightDetailsConfiguration : IEntityTypeConfiguration<FlightDetail>
    {
        public void Configure(EntityTypeBuilder<FlightDetail> builder)
        {
            builder.Property(p => p.BoardingStatus).IsRequired();
            builder.Property(p =>p.GateTime).IsRequired();
            builder.Property(p => p.Gate).IsRequired();
            builder.Property(p => p.Stand).IsRequired();
            builder.Property(p => p.Terminal).IsRequired();
            builder.Property(p => p.FlightDistance).IsRequired();
        }
    }
}
