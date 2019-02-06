using System.Collections.Generic;

namespace WebAPI.Models.Repository
{
    public interface IEventDetailRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long ID);
        void Add(TEntity entity);
        void Update(EventDetail eventDetail, TEntity entity);
        void Delete(EventDetail eventDetail);
    }
}