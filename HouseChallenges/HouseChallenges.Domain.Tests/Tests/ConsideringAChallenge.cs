using HouseChallenges.Domain.Entities;
using HouseChallenges.Domain.Tests.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HouseChallenges.Domain.Tests.Tests
{
    /// <summary>
    /// Summary description for ConsideringAChallenge
    /// </summary>
    [TestClass]
    public class ConsideringAChallenge
    {
        private readonly DomainFactory _factory;
        public ConsideringAChallenge()
        {
            _factory = new DomainFactory();
        }


        [TestMethod]
        public void ShouldAddAnActivity()
        {
            var challenge = _factory.GetNewChallengeInstance();
            Assert.AreEqual(challenge.Activities.Count, 0);

            challenge.AddActivity(new Activity());
            Assert.AreEqual(challenge.Activities.Count, 1);

        }

        [TestMethod]
        public void ShouldAddAPerson()
        {
            var challenge = _factory.GetNewChallengeInstance();
            Assert.AreEqual(challenge.People.Count, 0);

            challenge.AddParticipant(new Person());
            Assert.AreEqual(challenge.People.Count, 1);

        }

        [TestMethod]
        public void ShouldCalculateExecutedPoints()
        {
            var challenge = _factory.GetNewChallengeInstance();
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
            var challenge = _factory.GetNewChallengeInstance();
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
            var challenge = _factory.GetNewChallengeInstance();
            Assert.AreNotEqual(challenge.Id.ToString(), string.Empty);
        }


    }
}
