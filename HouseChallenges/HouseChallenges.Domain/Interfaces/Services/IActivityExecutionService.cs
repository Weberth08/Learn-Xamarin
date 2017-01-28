using HouseChallenges.Domain.Commands;
using HouseChallenges.Domain.Entities;

namespace HouseChallenges.Domain.Interfaces.Services
{
    public interface IActivityExecutionService : IService<ActivityExecution>
    {
        ActivityExecution Create(CreateActivityExecutionCommand command);
        void Cancel(CancelActivityExecutionCommand command);
        void Execute(ExecuteActivityCommand command);
        void Finish(FinishActivityExecutionCommand command);
        void PerformPartially(PerformExecutionPartiallyCommand command);
        void Start(StartActivityExecutionCommand command);
    }
}
