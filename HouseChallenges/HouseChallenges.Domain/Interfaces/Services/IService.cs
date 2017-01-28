using System.Collections.Generic;

namespace HouseChallenges.Domain.Interfaces.Services
{
    public interface IService<TEntity> where TEntity : class
    {
        void Dispose();
        TEntity Find(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity entity);
        void Remove(TEntity entity);
        void Add(TEntity entity);
    }
}
