namespace HouseChallenges.Domain.Commands
{
    public class PerformExecutionPartiallyCommand
    {
        public int ActivityExecutionId { get; set; }
        public int PersonId { get; set; }
    }
}
