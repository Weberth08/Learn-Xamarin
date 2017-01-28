using System.Collections.Generic;

namespace HouseChallenges.Application.Interfaces
{
    public interface IApplicationBase<TViewObject> where TViewObject : class
    {
        void Add(TViewObject viewModel);

        void Remove(TViewObject viewModel);

        void Update(TViewObject viewModel);

        IEnumerable<TViewObject> GetAll();
    }
}
