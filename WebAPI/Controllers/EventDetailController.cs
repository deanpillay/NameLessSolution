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
    [Route("api/[controller]")]
    [ApiController]
    public class EventDetailController : ControllerBase
    {
         private readonly IEventDetailRepository<EventDetail> _EventDetailRepository;

        public EventDetailController(IEventDetailRepository<EventDetail> EventDetailRepository)
        {
            _EventDetailRepository = EventDetailRepository;
        }

        // GET: api/EventDetail
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<EventDetail> EventDetails = _EventDetailRepository.GetAll();
            return Ok(EventDetails);
        }

        // GET: api/EventDetail/5
        [HttpGet("{id}", Name = "EventDetailGet")]
        public IActionResult Get(long id)
        {
            EventDetail EventDetail = _EventDetailRepository.Get(id);

            if (EventDetail == null)
            {
                return NotFound("The EventDetail couldn't be found.");
            }

            return Ok(EventDetail);
        }

        // POST: api/EventDetail
        [HttpPost]
        public IActionResult Post([FromBody] EventDetail EventDetail)
        {
            if (EventDetail == null)
            {
                return BadRequest("EventDetail is null.");
            }

            _EventDetailRepository.Add(EventDetail);
            return CreatedAtRoute(
                  "EventDetailGet",
                  new { Id = EventDetail.EventDetailID },
                  EventDetail);
        }

        // PUT: api/EventDetail/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] EventDetail EventDetail)
        {
            if (EventDetail == null)
            {
                return BadRequest("EventDetail is null.");
            }

            EventDetail EventDetailToUpdate = _EventDetailRepository.Get(id);
            if (EventDetailToUpdate == null)
            {
                return NotFound("The EventDetail couldn't be found.");
            }

            _EventDetailRepository.Update(EventDetailToUpdate, EventDetail);
            return NoContent();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            EventDetail EventDetail = _EventDetailRepository.Get(id);
            if (EventDetail == null)
            {
                return NotFound("The EventDetail couldn't be found.");
            }

            _EventDetailRepository.Delete(EventDetail);
            return NoContent();
        }
    }
}
