using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement_API.Application.Helpers
{
    public class PatchHelper
    {
        public void MapIfNotNull<T>(T source, Action<T> updateAction)
        {
            if (source != null && !EqualityComparer<T>.Default.Equals(source, default(T)))
            {
                updateAction(source);
            }
        }
    }
}
