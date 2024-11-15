using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CordiSimpleNet.Models;
using CordiSimpleNet.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CordiSimpleNet.Controllers.v1.events
{
    [ApiController]
    [Route("api/v1/events/[controller]")]
    [Tags("Event")]
    public class EventsGetController : EventsController
    {
        public EventsGetController(IEventRepository _EventRepository) : base(_EventRepository)
        {
        }

        [HttpGet("GetAllEvents")]
        public async Task<ActionResult<IEnumerable<Event>>> GetAction()
        {
            var events = await eventRepository.GetAll();
            if (events == null)
            {
                return NotFound("No tienes eventos disponibles");
            }
            return Ok(events);
        }

        [HttpGet("GetIdEvent/{id}")]
        public async Task<ActionResult<Event>> GetId(int id)
        {
            var events = await eventRepository.GetId(id);
            if (events == null)
            {
                return NotFound($"El evento con el id: {id}");
            }
            else
            {
                return Ok(events);
            }
        }

    }
}