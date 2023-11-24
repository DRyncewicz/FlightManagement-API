using FlightManagement_API.Application.Aircrafts.Commands.CreateAircraft;
using FlightManagement_API.Application.Aircrafts.Queries.GetAircraftInformation;
using FlightManagement_API.Application.Flights.Commands.CreateFlight;
using FlightManagement_API.Application.Flights.Queries.GetFlightInformation;
using IdentityModel.OidcClient;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightManagement_API.Controllers
{
    [Route("api/aircrafts")]
    [ApiController]
    public class AircraftController : BaseController
    {
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<AircraftInformationVm>> GetDetails(int id)
        {
            var vm = await Mediator.Send(new GetAircraftInformationQuery() { AircraftId = id });
            return vm;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> RegisterAircraft(CreateAircraftCommand command)
        {
            var result = await Mediator.Send(command);
            var locationUri = Url.Action("GetDetails", new { id = result });

            return Created(locationUri, result);
        }
    }
}
