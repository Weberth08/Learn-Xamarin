using HouseChallenges.Data.Context;
using HouseChallenges.Domain.Entities;
using HouseChallenges.Domain.Interfaces.Repositories;

namespace HouseChallenges.Data.Repositories
{
    public class ActivityRepository : RepositoryBase<Activity>, IActivityRepository
    {
        public ActivityRepository(EfHouseChallengesContext context) : base(context)
        {
        }
    }
}
