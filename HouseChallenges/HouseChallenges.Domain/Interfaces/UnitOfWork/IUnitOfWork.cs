using HouseChallenges.Domain.Interfaces.Repositories;
using System;

namespace HouseChallenges.Domain.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IActivityExecutionRepository ActivityExecutionRepository { get; }
        IActivityRepository ActivityRepository { get; }
        IPersonRepository PersonRepository { get; }
        int Commit();

    }
}
