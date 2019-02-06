using System.Collections.Generic;

namespace WebAPI.Models.Repository
{
    public interface IEventRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long ID);
        IEnumerable<TEntity> GetEvents(long ID);
        void Add(TEntity entity);
        void Update(Event evnt, TEntity entity);
        void Delete(Event evnt);
    }
}