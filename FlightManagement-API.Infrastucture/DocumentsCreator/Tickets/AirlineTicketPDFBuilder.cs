using FlightManagement_API.Application.Common.Interfaces.Documents;
using FlightManagement_API.Domain.Entities;
using FlightManagement_API.Infrastructure.DocumentsCreator.Tables;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace FlightManagement_API.Infrastructure.DocumentsCreator.Tickets
{
    public class AirlineTicketPDFBuilder : IAirlineTicketBuilder
    {
        private Document document;
        private MemoryStream memoryStream;
        private PdfWriter writer;

        public IDocumentBuilder CreateNewDocument()
        {
            document = new Document(PageSize.A4);
            memoryStream = new MemoryStream();
            writer = PdfWriter.GetInstance(document, memoryStream);
            document.Open();
            return this;
        }

        public IDocumentBuilder AddTitle(string title)
        {
            document.Add(new Paragraph(title, FontFactory.GetFont(FontFactory.HELVETICA, 18, Font.BOLD)));
            return this;
        }

        public IDocumentBuilder AddParagraph(string text)
        {
            document.Add(new Paragraph(text));
            return this;
        }

        public IDocumentBuilder AddImage(string imagePath)
        {
            Image image = Image.GetInstance(imagePath);
            document.Add(image);
            return this;
        }

        public IDocumentBuilder AddTable(ITableData tableData)
        {
            PdfPTable pdfTable = ConvertToPdfPTable(tableData);
            document.Add(pdfTable);
            return this;
        }

        public IAirlineTicketBuilder AddFlightDetails(Flight flight)
        {
            var tableData = new TableData();
            tableData.AddHeader("Flight date", "Flight time", "Flight number", "Gate");
            tableData.AddRow(
                flight.DepartureTime.Date.ToString(),
                flight.DepartureTime.TimeOfDay.ToString(),
                flight.FlightNumber,
                flight.FlightDetail.Gate
                );

            PdfPTable pdfTable = ConvertToPdfPTable(tableData);
            document.Add(pdfTable);

            return this;
        }

        public IAirlineTicketBuilder AddPassengerDetails(string passengerFullName, string bookingNumber)
        {
            var tableData = new TableData();
            tableData.AddHeader("Passenger Name", "Booking number");
            tableData.AddRow(passengerFullName, bookingNumber);
            PdfPTable pdfTable = ConvertToPdfPTable(tableData);
            document.Add(pdfTable);

            return this;
        }

        public IAirlineTicketBuilder AddQrCode(string qrCodeData)
        {

            BarcodeQRCode qrCode = new BarcodeQRCode(qrCodeData, 100, 100, null);
            Image qrCodeImage = qrCode.GetImage();
            document.Add(qrCodeImage);
            return this;
        }

        public IAirlineTicketBuilder AddTermsAndConditions(string terms)
        {
            document.Add(new Paragraph(terms));
            return this;
        }

        public byte[] Build()
        {
            document.Close();
            return memoryStream.ToArray();
        }

        private PdfPTable ConvertToPdfPTable(ITableData tableData)
        {
            var headers = tableData.GetHeaders();
            PdfPTable table = new PdfPTable(headers.Count);
            table.WidthPercentage = 100;

            foreach (var header in headers)
            {
                table.AddCell(new Phrase(header));
            }

            var rows = tableData.GetRows();
            foreach (var row in rows)
            {
                foreach (var cell in row)
                {
                    table.AddCell(new Phrase(cell));
                }
            }

            return table;
        }


    }
}
