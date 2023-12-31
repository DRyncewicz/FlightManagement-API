﻿using FlightManagement_API.Application.FlightPricing.Commands;
using FlightManagement_API.Application.Flights.Commands.CreateFlight;
using FlightManagement_API.Application.Flights.Commands.DeleteFlight;
using FlightManagement_API.Application.Flights.Commands.UpdateFlight;
using FlightManagement_API.Application.Flights.Queries.GetFilteredFlights;
using FlightManagement_API.Application.Flights.Queries.GetFlightInformation;
using FlightManagement_API.Application.Flights.Queries.GetFlightsForBoardVm;
using FlightManagement_API.Domain.Entities;
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<FlightInformationVm>> GetDetails(int id)
        {
            var vm = await Mediator.Send(new GetFlightInformationQuery() { FlightId = id });
            return vm;
        }

        [HttpGet("for-board")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<FlightsForBoardVm>> GetForBoard(int pageSize = 15, int page = 1)
        {
            var vm = await Mediator.Send(new GetFlightsForBoardQuery() {PageSize = pageSize, CurrentPage = page});
            return vm;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create(CreateFlightCommand command)
        {
            var result = await Mediator.Send(command);
            var locationUri = Url.Action("GetDetails", new { id = result });

            return Created(locationUri, result);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteFlightCommand { FlightId = id };
            await Mediator.Send(command);

            return NoContent();
        }

        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateFlightCommand command)
        {
            command.FlightId = id;
            var result = await Mediator.Send(command);

            return Ok(result);
        }

        [HttpGet("filtered")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ListFilteredFlightsVm>> GetFiltered(DateTime? departureDate, DateTime? arrivalDate, string departureIata, string arrivalIata, double? maxPrice, int currentPage = 1, int pageSize = 15)
        {
            var vm = await Mediator.Send(new GetFilteredFlightsQuery()
            {
                DepartureDate = departureDate, ArrivalDate = arrivalDate,
                DepartureAirport = departureIata, ArrivalAirport = arrivalIata,
                MaxPrice = maxPrice, CurrentPage = currentPage, PageSize = pageSize
            });

            return vm;
        }
    }
}
