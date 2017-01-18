using HouseChallenges.Domain.Enums;

namespace HouseChallenges.Domain.Entities
{
    public class Activity
    {
        public int Points { get; set; }

        public ActivityStatus Status { get; set; }

        public bool Executed => Status == ActivityStatus.Executed;

        public void Execute()
        {
            Status = ActivityStatus.Executed;
        }

        public void Start()
        {
            Status = ActivityStatus.InProgress;
        }

        public void Finish()
        {
            Status = ActivityStatus.Executed;
        }
    }
}
