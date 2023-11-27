using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement_API.Application.Common.Interfaces.Documents
{
    public interface IAirlineTicketBuilder : IDocumentBuilder
    {
        IAirlineTicketBuilder AddFlightDetails(string details);

        IAirlineTicketBuilder AddPassengerDetails(string passenger);

        IAirlineTicketBuilder AddQRCode(string qrCodeData);

        IAirlineTicketBuilder AddTermsAndConditions();
    }

}
