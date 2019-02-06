using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.Repository
{
    public class TournamentRepository : ITournamentRepository<Tournament>
    {
        ApplicationContext _context;

        public TournamentRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Tournament> GetAll()
        {
            return _context.Tournaments
                .Include(x => x.Events)
                    .ThenInclude(i => i.EventDetails)
                        .ThenInclude(j => j.EventDetailStatus)
                .ToList();
        }
               
        public Tournament Get(long ID)
        {
            return _context.Tournaments
                .Include(x => x.Events)
                    .ThenInclude(i => i.EventDetails)
                        .ThenInclude(j => j.EventDetailStatus)
                .FirstOrDefault(e => e.TournamentID == ID);
        }

        
        public void Add(Tournament entity)
        {
            _context.Tournaments.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Tournament tournament, Tournament entity)
        {
            tournament.TournamentName = entity.TournamentName;

            _context.SaveChanges();
        }

        public void Delete(Tournament tournament)
        {
            _context.Tournaments.Remove(tournament);
            _context.SaveChanges();
        }

    }
}
