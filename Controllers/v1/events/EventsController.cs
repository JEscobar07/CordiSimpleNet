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
    public class EventsController : ControllerBase
    {
        protected readonly IEventRepository eventRepository;
        public EventsController(IEventRepository _eventRespository){
            eventRepository = _eventRespository;
        }


    }
}