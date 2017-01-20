using HouseChallenges.Data.Context;
using HouseChallenges.Domain.Entities;
using HouseChallenges.Domain.Interfaces.Repositories;

namespace HouseChallenges.Data.Repositories
{
    public class ActivityExecutionRepository : RepositoryBase<ActivityExecution>, IActivityExecutionRepository
    {
        public ActivityExecutionRepository(EfHouseChallengesContext context) : base(context)
        {
        }
    }
}
