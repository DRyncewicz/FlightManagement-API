using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement_API.Application.Common.Exceptions
{
    public class NullPathException : Exception
    {
        public NullPathException(string name, object key)
            : base($"Null reference for path \"{name}\" ({key}).")
        {
        }
    }
}
