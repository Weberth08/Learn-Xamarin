using HouseChallenges.Domain.Entities;
using HouseChallenges.Domain.Interfaces.Repositories;
using HouseChallenges.Domain.Interfaces.Services;

namespace HouseChallenges.Domain.Services
{
    public class PersonService : ServiceBase<Person>, IPersonService
    {
        public PersonService(IRepositoryBase<Person> repository) : base(repository)
        {
        }
    }
}
