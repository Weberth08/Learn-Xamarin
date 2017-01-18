using HouseChallenges.Domain.Entities.Interfaces;
using HouseChallenges.Domain.Enums;
using System;

namespace HouseChallenges.Domain.Entities
{
    public class ActivityExecution : IActivityExecutionBase
    {
        protected ActivityExecution()
        {

        }

        public ActivityExecution(Person executor, Activity activity)
        {
            Activity = activity;
            Executor = executor;
        }

        public int Id { get; set; }
        public int Points { get; set; }
        public Person Executor;
        public Activity Activity;
        public DateTime StartDateTime { get; private set; }
        public DateTime EndDateTime { get; private set; }
        public DateTime CancelDateTime { get; private set; }
        public ActivityExecutionStatus ExecutionStatus { get; private set; } = ActivityExecutionStatus.NoStarted;

        protected virtual int PersonId { get; set; }
        protected virtual int ActivityId { get; set; }

        public bool Executed =>
            ExecutionStatus == ActivityExecutionStatus.Executed ||
            ExecutionStatus == ActivityExecutionStatus.PartiallyExecuted;

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
            ExecutionStatus = ActivityExecutionStatus.InProgress;
        }

        public void Finish()
        {
            CheckIfCanBePerformedAndThrowsExceptions();
            EndDateTime = DateTime.Now;
            ExecutionStatus = ActivityExecutionStatus.Executed;
        }

        public void PerformPartially()
        {
            CheckIfCanBePerformedAndThrowsExceptions();
            EndDateTime = DateTime.Now;
            ExecutionStatus = ActivityExecutionStatus.PartiallyExecuted;
        }

        public void Cancel()
        {
            CheckIfCanBeCanceledAndThrowsExceptions();
            CancelDateTime = DateTime.Now;
            ExecutionStatus = ActivityExecutionStatus.Canceled;
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
            if (!CanBePerformed(this)) throw new InvalidOperationException("You can't perform a non 'In Progress ExecutionStatus' Activity.");
        }



        #endregion


        #region Private Methods

        private bool CanBePerformed(ActivityExecution activity)
        {
            return activity.ExecutionStatus == ActivityExecutionStatus.InProgress;
        }


        private bool CanBeCanceled(ActivityExecution activity)
        {
            return activity.ExecutionStatus == ActivityExecutionStatus.InProgress;

        }

        private bool CanBeStarted(ActivityExecution activity)
        {
            return activity.ExecutionStatus == ActivityExecutionStatus.NoStarted;
        }
        #endregion
    }
}
