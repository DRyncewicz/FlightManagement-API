using FlightManagement_API.Application.DomainEvent.Event;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightManagement_API.Application.Common.Exceptions;
using FlightManagement_API.Application.Common.Interfaces.Database;
using FlightManagement_API.Application.Common.Interfaces.Documents;
using FlightManagement_API.Application.Common.Interfaces.Files;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FlightManagement_API.Application.DomainEvent.EventHandlers
{
    public class GenerateTicketEventHandler
    (
        IFlightDbContext flightDbContext,
        IAirlineTicketBuilder ticketBuilder,
        IFileStore fileStore,
        IConfiguration configuration,
        ILogger<GenerateTicketEventHandler> logger
    ) : INotificationHandler<BookingCreatedEvent>
    {
        public async Task Handle(BookingCreatedEvent notification, CancellationToken cancellationToken)
        {
            var booking = await flightDbContext.Bookings.Where(b => b.Id == notification.BookingId)
                .Include(b => b.Passenger)
                .Include(b => b.Flight)
                .ThenInclude(f => f.FlightDetail)
                .FirstOrDefaultAsync(cancellationToken);

            string bookingNumber = "B" + booking.Id.ToString();

            ticketBuilder.CreateNewDocument()
                .AddTitle("FLIGHT TICKET");
            var pdfContent = ticketBuilder.AddFlightDetails(booking.Flight)
                .AddPassengerDetails(booking.Passenger.FirstName + " " + booking.Passenger.LastName,
                    bookingNumber)
                .AddQrCode(booking.Flight.FlightNumber + bookingNumber)
                .AddTermsAndConditions("Terms and conditions")
                .Build();
            try
            {
                string filePath = configuration["FilePaths:TicketsOutputPath"];
                fileStore.SafeWriteFile(pdfContent, bookingNumber + ".pdf", filePath);
            }
            catch (NullPathException ex)
            {
                logger.LogInformation(ex,
                    "Null reference exception for path to store tickets.");
                throw;
            }
            catch (Exception ex)
            {
                logger.LogInformation(ex,
                    "Unhandled Exception for ticket generation");
            }
        }
    }
}
