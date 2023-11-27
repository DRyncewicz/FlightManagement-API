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
        public Flight Flight { get; }

        public Passenger Passenger { get; }

        public BookingCreatedEvent(Flight flight, Passenger passenger)
        {
            Flight = flight;
            Passenger = passenger;
        }
    }
}
