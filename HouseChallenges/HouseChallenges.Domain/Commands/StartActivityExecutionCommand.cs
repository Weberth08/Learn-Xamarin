namespace HouseChallenges.Domain.Commands
{
    public class StartActivityExecutionCommand
    {
        public int ActivityExecutionId { get; set; }
        public int PersonId { get; set; }
    }
}
