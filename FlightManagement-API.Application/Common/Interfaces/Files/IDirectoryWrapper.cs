﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement_API.Application.Common.Interfaces.Files
{
    public interface IDirectoryWrapper
    {
        void CreateDirectory(string path);
    }
}
