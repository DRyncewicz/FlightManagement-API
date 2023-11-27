using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Application.Common.Interfaces.Times;

namespace FlightManagement_API.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now  => DateTime.Now;
    }
}
