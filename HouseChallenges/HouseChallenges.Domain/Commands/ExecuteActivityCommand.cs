namespace HouseChallenges.Domain.Commands
{
    public class ExecuteActivityCommand : CommandBase
    {
        public int ExecutorId { get; set; }
        public int ActivityExecutionId { get; set; }
    }
}
