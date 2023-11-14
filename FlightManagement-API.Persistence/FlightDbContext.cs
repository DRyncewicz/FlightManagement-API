using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement_API.Persistence
{
    public class FlightDbContext : DbContext
    {

        public FlightDbContext(DbContextOptions<FlightDbContext> options) : base(options)
        {
            
        }
    }
}
