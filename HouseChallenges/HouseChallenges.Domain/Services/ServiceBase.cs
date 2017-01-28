using HouseChallenges.Domain.Interfaces.Repositories;
using HouseChallenges.Domain.Interfaces.Services;

using System.Collections.Generic;

namespace HouseChallenges.Domain.Services
{
    public abstract class ServiceBase<TEntity> : IService<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;


        protected ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }
        public void Dispose()
        {

        }

        public TEntity Find(int id)
        {
            return _repository.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }

        public void Remove(TEntity entity)
        {
            _repository.Remove(entity);
        }

        public void Add(TEntity entity)
        {
            _repository.Add(entity);
        }
    }
}
