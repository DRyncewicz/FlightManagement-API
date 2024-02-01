using FlightManagement_API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement_API.Application.Common.Interfaces.Documents
{
    public interface IAirlineTicketBuilder : IDocumentBuilder
    {
        IAirlineTicketBuilder AddFlightDetails(Flight flight);

        IAirlineTicketBuilder AddPassengerDetails(string passengerFullName, string bookingNumber);

        IAirlineTicketBuilder AddQrCode(string qrCodeData);

        IAirlineTicketBuilder AddTermsAndConditions(string terms);
    }
}
