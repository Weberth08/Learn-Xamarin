using HouseChallenges.Domain.Entities;
using HouseChallenges.Domain.Entities.Interfaces;

namespace HouseChallenges.Domain.Interfaces.Services
{
    public interface IActivityExecutionService : IService<IActivityExecutionBase>
    {
        IActivityExecutionBase Create(Person executor, Activity activity);
        void Cancel(IActivityExecutionBase activityExecution);
        void Execute(IActivityExecutionBase activityExecution);
        void Finish(IActivityExecutionBase activityExecution);
        void PerformPartially(IActivityExecutionBase activityExecution);
        void Start(IActivityExecutionBase activityExecution);
    }
}
