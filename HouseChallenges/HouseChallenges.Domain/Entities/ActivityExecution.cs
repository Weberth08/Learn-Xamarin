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
        public virtual Person Executor { get; set; }
        public virtual Activity Activity { get; set; }
        public DateTime? StartDateTime { get; private set; }
        public DateTime? EndDateTime { get; private set; }
        public DateTime? CancelDateTime { get; private set; }
        public ActivityExecutionStatus ExecutionStatus { get; private set; } = ActivityExecutionStatus.NoStarted;

        public int PersonId { get; set; }
        public int ActivityId { get; set; }

        public bool Executed =>
            ExecutionStatus == ActivityExecutionStatus.Executed ||
            ExecutionStatus == ActivityExecutionStatus.PartiallyExecuted;

        #region Public Methods

        public void Cancel(Person executor)
        {
            ChekIfIsTheSameExecutorAndThrowsExceptions(executor);
            Cancel();
        }

        public void Execute(Person executor)
        {
            ChekIfIsTheSameExecutorAndThrowsExceptions(executor);
            Execute();
        }

        public void Finish(Person executor)
        {
            ChekIfIsTheSameExecutorAndThrowsExceptions(executor);
            Finish();
        }

        public void PerformPartially(Person executor)
        {
            ChekIfIsTheSameExecutorAndThrowsExceptions(executor);
            PerformPartially();
        }

        public void Start(Person executor)
        {
            ChekIfIsTheSameExecutorAndThrowsExceptions(executor);
            Start();
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

        private void ChekIfIsTheSameExecutorAndThrowsExceptions(Person executor)
        {
            if (!SameExecutor(executor)) throw new InvalidOperationException("The Executors are not the Same. Operation Can't be realized.");

        }


        #endregion


        #region Private Methods

        private void Execute()
        {
            Start();
            Finish();
        }

        private void Start()
        {
            CheckIfCanBeStartedAndThrowsExceptions();
            StartDateTime = DateTime.Now;
            ExecutionStatus = ActivityExecutionStatus.InProgress;
        }

        private void Finish()
        {
            CheckIfCanBePerformedAndThrowsExceptions();
            EndDateTime = DateTime.Now;
            ExecutionStatus = ActivityExecutionStatus.Executed;
        }

        private void PerformPartially()
        {
            CheckIfCanBePerformedAndThrowsExceptions();
            EndDateTime = DateTime.Now;
            ExecutionStatus = ActivityExecutionStatus.PartiallyExecuted;
        }

        private void Cancel()
        {
            CheckIfCanBeCanceledAndThrowsExceptions();
            CancelDateTime = DateTime.Now;
            ExecutionStatus = ActivityExecutionStatus.Canceled;
        }

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

        private bool SameExecutor(Person executor)
        {
            return executor.Equals(Executor);
        }

        #endregion
    }
}
