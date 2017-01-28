using HouseChallenges.Domain.Entities;
using HouseChallenges.Domain.Interfaces.Repositories;
using HouseChallenges.Domain.Interfaces.Services;
using System;

namespace HouseChallenges.Domain.Services
{
    public class HomeTaskService : ServiceBase<HomeTask>, IHomeTaskService
    {
        public HomeTaskService(IRepositoryBase<HomeTask> repository) : base(repository)
        {
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
