namespace HouseChallenges.Domain.Commands
{
    public class CreateActivityExecutionCommand : CommandBase
    {
        public int ExecutorId { get; set; }
        public int ActivityId { get; set; }
    }
}