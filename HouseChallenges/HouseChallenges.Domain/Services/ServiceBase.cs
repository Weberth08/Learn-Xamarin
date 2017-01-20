using HouseChallenges.Domain.Interfaces.Services;
using HouseChallenges.Domain.Interfaces.UnitOfWork;

namespace HouseChallenges.Domain.Services
{
    public class ServiceBase<TEntity> : IService<TEntity> where TEntity : class
    {
        protected IUnitOfWork UnitOfWork;
        public ServiceBase(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
        public void Dispose()
        {
            using (UnitOfWork)
            {
                UnitOfWork.Dispose();
            }
        }

    }
}
