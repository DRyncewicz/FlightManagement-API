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
    public class FlightPricingConfiguration : IEntityTypeConfiguration<FlightPricing>
    {
        public void Configure(EntityTypeBuilder<FlightPricing> builder)
        {
         
        }
    }
}
