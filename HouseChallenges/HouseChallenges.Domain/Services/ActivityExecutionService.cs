using HouseChallenges.Domain.Entities;
using HouseChallenges.Domain.Entities.Interfaces;
using HouseChallenges.Domain.Interfaces.Services;

namespace HouseChallenges.Domain.Services
{
    public class ActivityExecutionService : IActivityExecutionService
    {
        public IActivityExecutionBase Create(Person executor, Activity activity)
        {
            //TODO: move it to a Factory
            return new ActivityExecution(executor, activity);
        }

        public void Cancel(IActivityExecutionBase activityExecution)
        {
            activityExecution.Cancel();
        }

        public void Execute(IActivityExecutionBase activityExecution)
        {
            activityExecution.Execute();
        }

        public void Finish(IActivityExecutionBase activityExecution)
        {
            activityExecution.Finish();
        }

        public void PerformPartially(IActivityExecutionBase activityExecution)
        {
            activityExecution.PerformPartially();
        }

        public void Start(IActivityExecutionBase activityExecution)
        {
            activityExecution.Start();
        }
    }
}
