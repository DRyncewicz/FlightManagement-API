using FlightManagement_API.Application.Airline.Commands.CreateAirline;
using FlightManagement_API.Application.Booking.Commands;
using FlightManagement_API.Application.DomainEvent.Event;
using FlightManagement_API.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace FlightManagement_API.Controllers
{
    [Route("api/bookings")]
    [ApiController]
    public class BookingController : BaseController
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create(CreateBookingCommand command)
        {
            var result = await Mediator.Send(command);
            //var locationUri = Url.Action("GetDetails", new { id = result });

            return Created("locationUri", result);
        }
    }
}
