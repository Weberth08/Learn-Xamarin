using HouseChallenges.Data.Context;
using HouseChallenges.Data.Repositories;
using HouseChallenges.Domain.Interfaces.Repositories;
using HouseChallenges.Domain.Interfaces.UnitOfWork;
using System;

namespace HouseChallenges.Data.UnitOfWork
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private ActivityExecutionRepository _activityExecutionRepository;
        private ActivityRepository _activityRepository;
        private PersonRepository _personRepository;
        private readonly EfHouseChallengesContext _context;
        private bool _isDisposed;

        public EfUnitOfWork(EfHouseChallengesContext context)
        {
            _context = context;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (_isDisposed) return;
            if (disposing)
            {
                _context.Dispose();
            }
            _isDisposed = true;
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        ~EfUnitOfWork()
        {
            Dispose(false);
        }

        public IActivityExecutionRepository ActivityExecutionRepository =>
            _activityExecutionRepository ?? (_activityExecutionRepository = new ActivityExecutionRepository(_context));

        public IActivityRepository ActivityRepository
            => _activityRepository ?? (_activityRepository = new ActivityRepository(_context));

        public IPersonRepository PersonRepository
            => _personRepository ?? (_personRepository = new PersonRepository(_context));





    }
}
