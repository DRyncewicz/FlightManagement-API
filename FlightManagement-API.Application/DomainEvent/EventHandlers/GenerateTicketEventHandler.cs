using FlightManagement_API.Application.DomainEvent.Event;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Application.Common.Interfaces.Documents;
using FlightManagement_API.Application.Common.Interfaces.Files;

namespace FlightManagement_API.Application.DomainEvent.EventHandlers
{
    public class GenerateTicketEventHandler(IAirlineTicketBuilder ticketBuilder, IFileStore fileStore) : INotificationHandler<BookingCreatedEvent>
    {
        public async Task Handle(BookingCreatedEvent notification, CancellationToken cancellationToken)
        {
            ticketBuilder.CreateNewDocument()
                .AddTitle("FLIGHT TICKET");
            ticketBuilder.AddFlightDetails()
                .AddPassengerDetails()
                .AddQRCode(notification)
                    .Build();

        }
    }
}
