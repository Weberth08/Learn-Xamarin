using HouseChallenges.Domain.Enums;
using System;

namespace HouseChallenges.Domain.Entities
{
    public class Activity
    {
        public int Id { get; set; }
        public int Points { get; set; }
        public DateTime StartDateTime { get; private set; }
        public DateTime EndDateTime { get; private set; }
        public DateTime CancelDateTime { get; private set; }

        public ActivityStatus Status { get; private set; } = ActivityStatus.NoStarted;

        public bool Executed => Status == ActivityStatus.Executed || Status == ActivityStatus.PartiallyExecuted;

        #region Public Methods
        public void Execute()
        {
            Start();
            Finish();
        }

        public void Start()
        {
            CheckIfCanBeStartedAndThrowsExceptions();
            StartDateTime = DateTime.Now;
            Status = ActivityStatus.InProgress;
        }


        public void Finish()
        {
            CheckIfCanBePerformedAndThrowsExceptions();
            EndDateTime = DateTime.Now;
            Status = ActivityStatus.Executed;
        }

        public void PerformPartially()
        {
            CheckIfCanBePerformedAndThrowsExceptions();
            EndDateTime = DateTime.Now;
            Status = ActivityStatus.PartiallyExecuted;
        }

        public void Cancel()
        {
            CheckIfCanBeCanceledAndThrowsExceptions();
            CancelDateTime = DateTime.Now;
            Status = ActivityStatus.Canceled;
        }


        #endregion


        #region Check and Validations rules

        private void CheckIfCanBeStartedAndThrowsExceptions()
        {
            if (!CanBeStarted(this)) throw new InvalidOperationException("You can't start this Activity.");
        }

        private void CheckIfCanBeCanceledAndThrowsExceptions()
        {
            if (!CanBeCanceled(this)) throw new InvalidOperationException("You can't cancel this Activity.");
        }

        private void CheckIfCanBePerformedAndThrowsExceptions()
        {
            if (!CanBePerformed(this)) throw new InvalidOperationException("You can't perform a non 'In Progress Status' Activity.");
        }



        #endregion


        #region Private Methods

        private bool CanBePerformed(Activity activity)
        {
            return activity.Status == ActivityStatus.InProgress;
        }


        private bool CanBeCanceled(Activity activity)
        {
            return activity.Status == ActivityStatus.InProgress;

        }

        private bool CanBeStarted(Activity activity)
        {
            return activity.Status == ActivityStatus.NoStarted;
        }
        #endregion
    }
}
