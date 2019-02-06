using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.Repository
{
    public class EventRepository : IEventRepository<Event>
    {
        private readonly ApplicationContext _context;

        public EventRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Event> GetAll()
        {
            return _context.Events
                .Include(i => i.EventDetails)
                    .ThenInclude(j => j.EventDetailStatus)
                .ToList();
        }

        public Event Get(long ID)
        {
            return _context.Events
                .Include(i => i.EventDetails)
                    .ThenInclude(j => j.EventDetailStatus)
                .FirstOrDefault(e => e.EventID == ID);
        }

        public IEnumerable<Event> GetEvents(long ID)
        {
            return _context.Events
                .Where(e => e.FK_TournamentID == ID)
                .ToList();
        }



        public void Add(Event entity)
        {
            _context.Events.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Event evnt, Event entity)
        {
            evnt.EventName = entity.EventName;
            evnt.EventNumber = entity.EventNumber;
            evnt.EventDateTime = entity.EventDateTime;
            evnt.EventEndDateTime = entity.EventEndDateTime;
            evnt.AutoClose = evnt.AutoClose;

            _context.SaveChanges();
        }

        public void Delete(Event evnt)
        {
            _context.Events.Remove(evnt);
            _context.SaveChanges();
        }
    }
}
