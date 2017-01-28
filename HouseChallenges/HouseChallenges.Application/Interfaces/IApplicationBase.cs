using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
