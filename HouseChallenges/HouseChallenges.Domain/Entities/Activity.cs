using HouseChallenges.Domain.Enums;
using System;

namespace HouseChallenges.Domain.Entities
{
    public class Activity
    {
        public int Points { get; set; }
        public DateTime StartDateTime { get; private set; }
        public DateTime EndDateTime { get; private set; }

        public ActivityStatus Status { get; private set; } = ActivityStatus.NoStarted;

        public bool Executed => Status == ActivityStatus.Executed || Status == ActivityStatus.PartiallyExecuted;

        public void Execute()
        {
            var now = StartDateTime = DateTime.Now;
            StartDateTime = now;
            EndDateTime = now;
            Status = ActivityStatus.Executed;
        }

        public void Start()
        {
            StartDateTime = DateTime.Now;
            Status = ActivityStatus.InProgress;
        }

        public void Finish()
        {
            EndDateTime = DateTime.Now;
            Status = ActivityStatus.Executed;
        }

        public void FinishPartially()
        {
            EndDateTime = DateTime.Now;
            Status = ActivityStatus.PartiallyExecuted;
        }
    }
}
