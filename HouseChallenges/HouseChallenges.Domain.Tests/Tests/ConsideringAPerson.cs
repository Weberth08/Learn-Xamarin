using HouseChallenges.Domain.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HouseChallenges.Domain.Tests.Tests
{
    /// <summary>
    /// Summary description for ConsideringAPerson
    /// </summary>
    [TestClass]
    public class ConsideringAPerson : BaseTest
    {
        public ConsideringAPerson()
        {

        }


        [TestMethod]
        public void MustHaveAName()
        {
            var person = Factory.GetNewPersonInstance();
            Assert.AreNotEqual(true, string.IsNullOrEmpty(person.Name));
        }

        [TestMethod]
        public void MustExecuteAnActivity()
        {
            var person = Factory.GetNewPersonInstance();
            var activity = Factory.GetNewActivityExecutionInstance(person);
            Assert.AreEqual(false, activity.Executed);

            person.Execute(activity);
            Assert.AreEqual(true, activity.Executed);

        }

        [TestMethod]
        public void MustStartAndFinishAnActivity()
        {
            var person = Factory.GetNewPersonInstance();
            var activity = Factory.GetNewActivityExecutionInstance();
            Assert.AreEqual(true, activity.ExecutionStatus == ActivityExecutionStatus.NoStarted);

            person.StartActivity(activity);
            Assert.AreEqual(true, activity.ExecutionStatus == ActivityExecutionStatus.InProgress);

            person.FinishActivity(activity);
            Assert.AreEqual(true, activity.ExecutionStatus == ActivityExecutionStatus.Executed);

        }

        [TestMethod]
        public void MustStartAndFinishPartiallyAnActivity()
        {
            var person = Factory.GetNewPersonInstance();
            var activity = Factory.GetNewActivityExecutionInstance();
            Assert.AreEqual(true, activity.ExecutionStatus == ActivityExecutionStatus.NoStarted);

            person.StartActivity(activity);
            Assert.AreEqual(true, activity.ExecutionStatus == ActivityExecutionStatus.InProgress);

            person.FinishPartiallyActivity(activity);
            Assert.AreEqual(true, activity.ExecutionStatus == ActivityExecutionStatus.PartiallyExecuted);

        }

        [TestMethod]
        public void MustCancelAnActivity()
        {
            var person = Factory.GetNewPersonInstance();
            var activity = Factory.GetNewActivityExecutionInstance();
            Assert.AreEqual(true, activity.ExecutionStatus == ActivityExecutionStatus.NoStarted);

            person.StartActivity(activity);
            Assert.AreEqual(true, activity.ExecutionStatus == ActivityExecutionStatus.InProgress);

            person.CancelActivity(activity);
            Assert.AreEqual(true, activity.ExecutionStatus == ActivityExecutionStatus.Canceled);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CanNotCancelAnPerformedActivity()
        {
            var person = Factory.GetNewPersonInstance();
            var activity = Factory.GetNewActivityExecutionInstance();
            Assert.AreEqual(true, activity.ExecutionStatus == ActivityExecutionStatus.NoStarted);

            person.StartActivity(activity);
            Assert.AreEqual(true, activity.ExecutionStatus == ActivityExecutionStatus.InProgress);

            person.FinishActivity(activity);

            person.CancelActivity(activity);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CanNotCancelAnPerformedPartiallyActivity()
        {
            var person = Factory.GetNewPersonInstance();
            var activity = Factory.GetNewActivityExecutionInstance();
            Assert.AreEqual(true, activity.ExecutionStatus == ActivityExecutionStatus.NoStarted);

            person.StartActivity(activity);
            person.FinishPartiallyActivity(activity);

            person.CancelActivity(activity);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CanNotStartAnCanceledActivity()
        {
            var person = Factory.GetNewPersonInstance();
            var activity = Factory.GetNewActivityExecutionInstance();
            Assert.AreEqual(true, activity.ExecutionStatus == ActivityExecutionStatus.NoStarted);

            person.StartActivity(activity);
            person.CancelActivity(activity);

            person.StartActivity(activity);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CanNotStartAnStartedActivity()
        {
            var person = Factory.GetNewPersonInstance();
            var activity = Factory.GetNewActivityExecutionInstance();
            Assert.AreEqual(true, activity.ExecutionStatus == ActivityExecutionStatus.NoStarted);

            person.StartActivity(activity);
            person.StartActivity(activity);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CanNotStartAPerformedPartiallyActivity()
        {
            var person = Factory.GetNewPersonInstance();
            var activity = Factory.GetNewActivityExecutionInstance();
            Assert.AreEqual(true, activity.ExecutionStatus == ActivityExecutionStatus.NoStarted);

            person.StartActivity(activity);
            person.FinishPartiallyActivity(activity);
            person.StartActivity(activity);

        }



        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CanNotFinishAPerformedPartiallyActivity()
        {
            var person = Factory.GetNewPersonInstance();
            var activity = Factory.GetNewActivityExecutionInstance();
            Assert.AreEqual(true, activity.ExecutionStatus == ActivityExecutionStatus.NoStarted);

            person.StartActivity(activity);
            person.FinishPartiallyActivity(activity);
            person.FinishActivity(activity);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CanNotFinishAPerformedActivity()
        {
            var person = Factory.GetNewPersonInstance();
            var activity = Factory.GetNewActivityExecutionInstance();
            Assert.AreEqual(true, activity.ExecutionStatus == ActivityExecutionStatus.NoStarted);

            person.StartActivity(activity);
            person.FinishActivity(activity);
            person.FinishActivity(activity);

        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CanNotExecuteActivityThatNotBelongHim()
        {
            var person = Factory.GetNewPersonInstance();
            var person2 = Factory.GetNewPersonInstance();
            person2.Name = "Person 2";
            var activity = Factory.GetNewActivityExecutionInstance(person);
            Assert.AreEqual(true, activity.ExecutionStatus == ActivityExecutionStatus.NoStarted);

            person2.StartActivity(activity);

        }
    }

}
