using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FlightManagement_API.Application.Common.Interfaces.Database;
using FlightManagement_API.Application.Common.Interfaces.Documents;
using FlightManagement_API.Application.Common.Interfaces.Files;
using FlightManagement_API.Application.DomainEvent.Event;
using FlightManagement_API.Domain.Entities;
using MediatR;

namespace FlightManagement_API.Application.Booking.Commands
{
    public class CreateBookingCommandHandler(IFlightDbContext flightDbContext, IMapper mapper, IMediator mediator) : IRequestHandler<CreateBookingCommand, int>
    {
        public async Task<int> Handle(CreateBookingCommand request, CancellationToken cancellationToken)
        {
            Domain.Entities.Booking booking = mapper.Map<Domain.Entities.Booking>(request);
            var luggage = mapper.Map<Luggage>(request);
            if (!request.PassengerId.HasValue)
            {
                var passenger = mapper.Map<Passenger>(request);
                await flightDbContext.Passengers.AddAsync(passenger, cancellationToken);
                booking.Passenger = passenger;
                luggage.Passenger = passenger;
            }
            else
            {
                booking.PassengerId = request.PassengerId.Value;
                luggage.PassengerId = request.PassengerId.Value;
            }

            await flightDbContext.Bookings.AddAsync(booking, cancellationToken);
            await flightDbContext.Luggages.AddAsync(luggage, cancellationToken);
            await flightDbContext.SaveChangesAsync(cancellationToken);
            await mediator.Publish(new BookingCreatedEvent(booking.Id), cancellationToken);

            return booking.Id;
        }
    }
}
