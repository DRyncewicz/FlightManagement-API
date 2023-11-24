using FlightManagement_API.Application.FlightPricing.Commands.CreateOfferForFlight;
using FlightManagement_API.Application.FlightPricing.Queries.GetOfferInformation;
using FlightManagement_API.Application.Flights.Queries.GetFlightInformation;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightManagement_API.Controllers
{
    [Route("api/offers")]
    [EnableCors("MyAllowSpecificOrigins")]
    public class OfferController : BaseController
    {
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<OfferInformationVm>> GetDetails(int id)
        {
            var vm = await Mediator.Send(new GetOfferInformationQuery() { OfferId = id });
            return vm;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create(CreateOfferForFlightCommand command)
        {
            var result = await Mediator.Send(command);
            var locationUri = Url.Action("GetDetails", new { id = result });

            return Created(locationUri, result);
        }
    }
}
