using FlightManagement_API.Application.Aircrafts.Queries.GetAircraftInformation;
using FlightManagement_API.Application.Flights.Queries.GetFlightInformation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightManagement_API.Controllers
{
    [Route("api/[controller]")]
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
    }
}
