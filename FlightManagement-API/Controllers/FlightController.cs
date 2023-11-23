﻿using FlightManagement_API.Application.Flights.Commands.CreateFlight;
using FlightManagement_API.Application.Flights.Queries.GetFlightInformation;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightManagement_API.Controllers
{
    [Route("api/flights")]
    [EnableCors("MyAllowSpecificOrigins")]
    public class FlightController : BaseController
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<FlightInformationVm>> GetDetails(int id)
        {
            var vm = await Mediator.Send(new GetFlightInformationQuery() { FlightId = id });
            return vm;
        }

        [HttpPost]
        public async Task<IActionResult> CreateFlight(CreateFlightCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }
    }
}
