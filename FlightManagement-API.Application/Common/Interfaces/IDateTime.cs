﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement_API.Application.Common.Interfaces
{
    public interface IDateTime
    {
        DateTime Now { get; }
    }
}