namespace HouseChallenges.Domain.Entities.Interfaces
{
    public interface IActivityExecutionBase
    {
        void Cancel(Person executor);
        void Execute(Person executor);
        void Finish(Person executor);
        void PerformPartially(Person executor);
        void Start(Person executor);
    }
}