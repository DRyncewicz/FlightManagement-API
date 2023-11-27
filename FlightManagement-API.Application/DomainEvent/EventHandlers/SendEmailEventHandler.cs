using FlightManagement_API.Application.DomainEvent.Event;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement_API.Application.DomainEvent.EventHandlers
{
    public class SendEmailEventHandler : INotificationHandler<BookingCreatedEvent>
    {

        public Task Handle(BookingCreatedEvent notification, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}