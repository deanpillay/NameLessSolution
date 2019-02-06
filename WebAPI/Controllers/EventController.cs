using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Models.Repository;

namespace WebAPI.Controllers
{
    [Route("api/event")]
    [ApiController]
    public class EventController : Controller
    {
        private readonly IEventRepository<Event> _eventRepository;

        public EventController(IEventRepository<Event> eventRepository)
        { 
            _eventRepository = eventRepository;
        }

        // GET: api/Event
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Event> Events = _eventRepository.GetAll();
            return Ok(Events);
        }

        // GET: api/Event/5
        [HttpGet("{id}", Name = "EventGet")]
        public IActionResult Get(long id)
        {
            IEnumerable<Event> Events = _eventRepository.GetEvents(id);

            //if (Event == null)
            //{
            //    return NotFound("The Event couldn't be found.");
            //}

            return Ok(Events);
        }

        // POST: api/Event
        [HttpPost]
        public IActionResult Post([FromBody] Event Event)
        {
            if (Event == null)
            {
                return BadRequest("Event is null.");
            }

            _eventRepository.Add(Event);
            return CreatedAtRoute(
                  "EventGet",
                  new { Id = Event.EventID },
                  Event);
        }

        // PUT: api/Event/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Event Event)
        {
            if (Event == null)
            {
                return BadRequest("Event is null.");
            }

            Event EventToUpdate = _eventRepository.Get(id);
            if (EventToUpdate == null)
            {
                return NotFound("The Event couldn't be found.");
            }

            _eventRepository.Update(EventToUpdate, Event);
            return NoContent();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Event Event = _eventRepository.Get(id);
            if (Event == null)
            {
                return NotFound("The Event couldn't be found.");
            }

            _eventRepository.Delete(Event);
            return NoContent();
        }
    }
}
