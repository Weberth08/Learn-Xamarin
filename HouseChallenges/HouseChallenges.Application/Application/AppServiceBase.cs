using HouseChallenges.Application.Interfaces;
using HouseChallenges.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace HouseChallenges.Application.Application
{
    public abstract class AppServiceBase<TEntity, TViewObject> : IApplicationBase<TViewObject> where TEntity : class where TViewObject : class
    {
        private IService<TEntity> _service;
        protected AppServiceBase(IService<TEntity> service)
        {
            _service = service;
        }

        public void Add(TViewObject viewModel)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(TViewObject viewModel)
        {
            throw new System.NotImplementedException();
        }

        public void Update(TViewObject viewModel)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TViewObject> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
