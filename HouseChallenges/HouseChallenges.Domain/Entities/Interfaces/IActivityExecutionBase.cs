namespace HouseChallenges.Domain.Entities.Interfaces
{
    public interface IActivityExecutionBase
    {
        void Cancel();
        void Execute();
        void Finish();
        void PerformPartially();
        void Start();
    }
}