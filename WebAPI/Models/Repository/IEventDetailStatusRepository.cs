using System.Collections.Generic;

namespace WebAPI.Models.Repository
{
    public interface IEventDetailStatusRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int ID);
    }
}