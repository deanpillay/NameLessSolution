using System.Collections.Generic;

namespace WebAPI.Models.Repository
{
    public interface ITournamentRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long ID);
        void Add(TEntity entity);
        void Update(Tournament tournament, TEntity entity);
        void Delete(Tournament tournament);
    }
}