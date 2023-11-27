using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement_API.Application.Common.Interfaces.Documents
{
    public interface IDocumentBuilder
    {
        IDocumentBuilder CreateNewDocument();

        IDocumentBuilder AddTitle(string title);

        IDocumentBuilder AddParagraph(string text);

        IDocumentBuilder AddImage(string imagePath);

        public IDocumentBuilder AddTable(ITableData table);

        byte[] Build();
    }

}
