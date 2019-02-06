using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.Repository
{
    public class EventDetailStatusRepository : IEventDetailStatusRepository<EventDetailStatus>
    {
        readonly ApplicationContext _context;

        public EventDetailStatusRepository(ApplicationContext context)
        {
            _context = context;
        }

        public EventDetailStatus Get(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EventDetailStatus> GetAll()
        {
            return _context.EventDetailStatuses.ToList();
        }
    }
}
