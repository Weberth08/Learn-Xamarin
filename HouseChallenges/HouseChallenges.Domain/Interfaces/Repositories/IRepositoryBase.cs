using System.Collections.Generic;

namespace HouseChallenges.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<Tentity> where Tentity : class
    {
        Tentity Find(int Id);
        IEnumerable<Tentity> GetAll();
        void Update(Tentity entity);
        void Remove(Tentity entity);
        void Add(Tentity entity);
    }
}
