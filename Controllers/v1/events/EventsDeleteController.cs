using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CordiSimpleNet.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CordiSimpleNet.Controllers.v1.events
{
    [ApiController]
    [Route("api/v1/events/[controller]")]
    [Tags("Event")]
    public class EventsDeleteController : EventsController
    {
        public EventsDeleteController(IEventRepository _eventRespository) : base(_eventRespository)
        {
        }

        [HttpDelete("events/{id}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            if( await eventRepository.Delete(id) == true){
                return Ok("Event successfully removed");
            }else{
                return BadRequest("We are sorry but the event is not in our system");
            }
        }
    }
}