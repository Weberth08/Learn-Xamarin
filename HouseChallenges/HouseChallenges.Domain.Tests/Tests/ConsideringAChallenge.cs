using HouseChallenges.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HouseChallenges.Domain.Tests.Tests
{
    /// <summary>
    /// Summary description for ConsideringAChallenge
    /// </summary>
    [TestClass]
    public class ConsideringAChallenge
    {
        private ChallengeBase _challengeBase;
        public ConsideringAChallenge()
        {
            _challengeBase = GetNewChallengeInstance();
        }


        [TestMethod]
        public void ShouldAddAnActivity()
        {
            Assert.AreEqual(_challengeBase.Activities.Count, 0);

            _challengeBase.AddActivity(new Activity());
            Assert.AreEqual(_challengeBase.Activities.Count, 1);

        }

        [TestMethod]
        public void ShouldAddAPerson()
        {
            var challenge = GetNewChallengeInstance();
            Assert.AreEqual(challenge.People.Count, 0);

            challenge.AddParticipant(new Person());
            Assert.AreEqual(challenge.People.Count, 1);

        }

        [TestMethod]
        public void ShouldCalculateExecutedPoints()
        {
            var challenge = GetNewChallengeInstance();
            var executedActivity = new Activity
            {
                Points = 500,
                Executed = true
            };

            challenge.AddActivity(executedActivity);

            Assert.AreEqual(challenge.ExecutedPoints, 500);
        }

        [TestMethod]
        public void ShouldCalculateEstimatedPoints()
        {
            var challenge = GetNewChallengeInstance();
            var executedActivity = new Activity
            {
                Points = 500,
                Executed = true
            };

            var nonExecutedActivity = new Activity
            {
                Points = 500,
                Executed = false
            };

            challenge.AddActivity(executedActivity);
            challenge.AddActivity(nonExecutedActivity);

            Assert.AreEqual(challenge.TotalPoints, 1000);
        }

        [TestMethod]
        public void ShouldBeAnId()
        {
            var challenge = GetNewChallengeInstance();
            Assert.AreNotEqual(challenge.Id.ToString(), string.Empty);
        }

        private ChallengeBase GetNewChallengeInstance() =>
            new ChallengeBase("Test", DateTime.Now, DateTime.Now);


    }
}
