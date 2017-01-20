using HouseChallenges.Data.Context;
using HouseChallenges.Domain.Entities;
using HouseChallenges.Domain.Interfaces.Repositories;

namespace HouseChallenges.Data.Repositories
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(EfHouseChallengesContext context) : base(context)
        {
        }
    }
}
