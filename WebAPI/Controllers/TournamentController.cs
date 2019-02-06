using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Models.Repository;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class TournamentController : ControllerBase
    {
        private readonly ITournamentRepository<Tournament> _tournamentRepository;

        public TournamentController(ITournamentRepository<Tournament> tournamentRepository)
        {
            _tournamentRepository = tournamentRepository;
        }

        // GET: api/Tournament
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Tournament> tournaments = _tournamentRepository.GetAll();
            return Ok(tournaments);
        }

        // GET: api/Tournament/5
        [HttpGet("{id}", Name = "TournamentGet")]
        public IActionResult Get(long id)
        {
            Tournament tournament = _tournamentRepository.Get(id);

            if(tournament == null)
            {
                return NotFound("The Tournament couldn't be found.");
            }

            return Ok(tournament);
        }

        // POST: api/Tournament
        [HttpPost]
        public IActionResult Post([FromBody] Tournament tournament)
        {
            if (tournament == null)
            {
                return BadRequest("Tournament is null.");
            }

            _tournamentRepository.Add(tournament);
            return CreatedAtRoute(
                  "TournamentGet",
                  new { Id = tournament.TournamentID },
                  tournament);
        }

        // PUT: api/Tournament/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Tournament tournament)
        {
            if (tournament == null)
            {
                return BadRequest("Tournament is null.");
            }

            Tournament tournamentToUpdate = _tournamentRepository.Get(id);
            if (tournamentToUpdate == null)
            {
                return NotFound("The Tournament couldn't be found.");
            }

            _tournamentRepository.Update(tournamentToUpdate, tournament);
            return NoContent();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Tournament tournament = _tournamentRepository.Get(id);
            if (tournament == null)
            {
                return NotFound("The Tournament couldn't be found.");
            }

            _tournamentRepository.Delete(tournament);
            return NoContent();
        }
    }
}
