using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Application.Common.Interfaces.Documents;

namespace FlightManagement_API.Infrastructure.DocumentsCreator.Tables
{
    public class TableData : ITableData
    {
        public List<string> Headers { get; set; }
        public List<List<string>> Rows { get; set; }

        public TableData()
        {
            Headers = new List<string>();
            Rows = new List<List<string>>();
        }

        public void AddHeader(params string[] headers)
        {
            Headers.AddRange(headers);
        }

        public void AddRow(params string[] row)
        {
            Rows.Add(new List<string>(row));
        }

        public List<string> GetHeaders()
        {
            return Headers;
        }

        public List<List<string>> GetRows()
        {
            return Rows;
        }
    }
}
