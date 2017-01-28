namespace HouseChallenges.Domain.Commands
{
    public class FinishActivityExecutionCommand
    {
        public int ActivityExecutionId { get; set; }
        public int PersonId { get; set; }
    }
}
