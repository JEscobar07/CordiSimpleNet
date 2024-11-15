using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CordiSimpleNet.DTOS;
using CordiSimpleNet.Models;
using CordiSimpleNet.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CordiSimpleNet.Controllers.v1.events
{
    [ApiController]
    [Route("api/v1/events/[controller]")]
    [Tags("Event")]
    public class EventsPostController : EventsController
    {
        public EventsPostController(IEventRepository _eventRespository) : base(_eventRespository)
        {
        }

        [HttpPost]
        [Authorize]
        [SwaggerOperation(
            Summary = "Creacion de event",
            Description = "Permite crear un nuevo evento"
        )]
        [SwaggerResponse(400,"Modelo incorrecto")]
        [SwaggerResponse(200,"evento creado")]
        public async Task<ActionResult> PostCreateEvent([FromBody] EventDTO ev)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var eventSave = new Event()
            {
                Name = ev.Name,
                Description = ev.Description,
                Date_start = ev.Date_start,
                Date_end = ev.Date_end,
                Location = ev.Location,
                Max_slots = ev.Max_slots,
                Occupied_slots = 0,
                Status = true
            };
            await eventRepository.Add(eventSave);
            return Ok("Event saved successfully");
        }
    }
}