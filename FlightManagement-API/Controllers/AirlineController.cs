using FlightManagement_API.Application.Aircrafts.Queries.GetAircraftInformation;
using FlightManagement_API.Application.Airline.Commands.CreateAirline;
using FlightManagement_API.Application.Airline.Commands.CreateAirlineContact;
using FlightManagement_API.Application.Airline.Queries.GetAirlineInformation;
using IdentityModel.OidcClient;
using Microsoft.AspNetCore.Mvc;

namespace FlightManagement_API.Controllers
{
    [Route("api/airlines")]
    [ApiController]
    public class AirlineController : BaseController
    {
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<AirlineInformationVm>> GetDetails(int id)
        {
            var vm = await Mediator.Send(new GetAirlineInformationQuery() { AirlineId = id });
            return vm;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Register(CreateAirlineCommand command)
        {
            var result = await Mediator.Send(command);
            var locationUri = Url.Action("GetDetails", new { id = result });

            return Created(locationUri, result);
        }

        [HttpPost]
        [Route("contacts")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create(CreateAirlineContactCommand command)
        {
            var result = await Mediator.Send(command);
            var locationUri = Url.Action("GetDetails", new { id = result });

            return Created(locationUri, result);
        }
    }
}
