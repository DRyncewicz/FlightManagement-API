using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement_API.Application.Common.Interfaces.Documents
{
    public interface ITableData
    {
        public void AddHeader(params string[] headers);

        public void AddRow(params string[] row);

        List<string> GetHeaders();

        List<List<string>> GetRows();
    }
}
