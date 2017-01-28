namespace HouseChallenges.Domain.Commands
{
    public class CancelActivityExecutionCommand : CommandBase
    {
        public int ActivityExecutionId { get; set; }
        public int PersonId { get; set; }
    }
}
