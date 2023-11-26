using FlightManagement_API.Application.Airline.Commands.CreateAirline;
using FlightManagement_API.Application.Booking.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightManagement_API.Controllers
{
    [Route("api/[controller]")]
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
