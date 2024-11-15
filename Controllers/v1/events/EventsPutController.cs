using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CordiSimpleNet.DTOS;
using CordiSimpleNet.Models;
using CordiSimpleNet.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CordiSimpleNet.Controllers.v1.events
{
    [ApiController]
    [Route("api/v1/events/[controller]")]
    [Tags("Event")]
    public class EventsPutController : EventsController
    {
        public EventsPutController(IEventRepository _eventRespository) : base(_eventRespository)
        {
        }

        [HttpPut("events/{id}")]
        public async Task<ActionResult<Event>> Update([FromBody] EventUpdateDTO eventDTO, [FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var eventFound = await eventRepository.GetId(id);
            if (eventFound == null)
            {
                return NotFound("No event found for the given id");
            }
            eventFound.Name = eventDTO.Name;
            eventFound.Description = eventDTO.Description;
            eventFound.Date_start = eventDTO.Date_start;
            eventFound.Date_end = eventDTO.Date_end;
            eventFound.Location = eventDTO.Location;
            eventFound.Max_slots = eventDTO.Max_slots;
            eventFound.Occupied_slots = eventDTO.Occupied_slots;
            eventFound.Status = eventDTO.Status;
            
            return Ok(await eventRepository.Update(id, eventFound));
        }
    }
}