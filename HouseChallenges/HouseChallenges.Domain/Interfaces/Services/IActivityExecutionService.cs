using HouseChallenges.Domain.Entities;

namespace HouseChallenges.Domain.Interfaces.Services
{
    public interface IActivityExecutionService : IService<ActivityExecution>
    {
        ActivityExecution Create(Person executor, Activity activity);
        void Cancel(ActivityExecution activityExecution, Person executor);
        void Execute(ActivityExecution activityExecution, Person executor);
        void Finish(ActivityExecution activityExecution, Person executor);
        void PerformPartially(ActivityExecution activityExecution, Person executor);
        void Start(ActivityExecution activityExecution, Person executor);
    }
}
