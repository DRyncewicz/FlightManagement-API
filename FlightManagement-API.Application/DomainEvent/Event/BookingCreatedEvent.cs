using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Domain.Entities;

namespace FlightManagement_API.Application.DomainEvent.Event
{
    public class BookingCreatedEvent : INotification
    {
        public int BookingId { get; }

        public BookingCreatedEvent(int bookingId)
        {
            BookingId = bookingId;
        }
    }
}
