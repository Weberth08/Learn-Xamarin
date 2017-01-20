using HouseChallenges.Data.Context;
using HouseChallenges.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HouseChallenges.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected EfHouseChallengesContext Db;

        public RepositoryBase(EfHouseChallengesContext context)
        {
            Db = context;
        }

        public TEntity Find(int Id)
        {
            return Db.Set<TEntity>().Find(Id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public void Update(TEntity entity)
        {
            Db.Entry<TEntity>(entity).State = EntityState.Modified;
        }

        public void Remove(TEntity entity)
        {
            Db.Entry<TEntity>(entity).State = EntityState.Deleted;
        }

        public void Add(TEntity entity)
        {
            Db.Entry<TEntity>(entity).State = EntityState.Added;
        }
    }
}
