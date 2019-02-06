using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.Repository
{
    public class EventDetailRepository : IEventDetailRepository<EventDetail>
    {
        ApplicationContext _context;

        public EventDetailRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<EventDetail> GetAll()
        {
            return _context.EventDetails
                .Include(j => j.EventDetailStatus)
                .ToList();
        }

        public EventDetail Get(long ID)
        {
            return _context.EventDetails
                .Include(j => j.EventDetailStatus)
                .FirstOrDefault(e => e.EventDetailID == ID);
        }


        public void Add(EventDetail entity)
        {
            _context.EventDetails.Add(entity);
            _context.SaveChanges();
        }

        public void Update(EventDetail evnt, EventDetail entity)
        {
            evnt.EventDetailName = entity.EventDetailName;
            evnt.EventDetailNumber = entity.EventDetailNumber;
            evnt.EventDetailOdd = entity.EventDetailOdd;
            evnt.FinishingPosition = entity.FinishingPosition;
            evnt.FirstTimer = evnt.FirstTimer;

            _context.SaveChanges();
        }

        public void Delete(EventDetail evnt)
        {
            _context.EventDetails.Remove(evnt);
            _context.SaveChanges();
        }
    }
}
