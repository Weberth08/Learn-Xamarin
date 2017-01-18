using HouseChallenges.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HouseChallenges.Domain.Tests.Tests
{
    /// <summary>
    /// Summary description for ConsideringAChallenge
    /// </summary>
    [TestClass]
    public class ConsideringAChallenge : BaseTest
    {

        public ConsideringAChallenge()
        {

        }


        [TestMethod]
        public void MustAddAnActivity()
        {
            var challenge = Factory.GetNewChallengeInstance();
            Assert.AreEqual(challenge.Activities.Count, 0);

            challenge.AddActivity(new Activity());
            Assert.AreEqual(challenge.Activities.Count, 1);

        }

        [TestMethod]
        public void MustAddAPerson()
        {
            var challenge = Factory.GetNewChallengeInstance();
            Assert.AreEqual(challenge.People.Count, 0);

            challenge.AddParticipant(Factory.GetNewPersonInstance());
            Assert.AreEqual(challenge.People.Count, 1);

        }

        [TestMethod]
        public void MustCalculateExecutedPoints()
        {
            var challenge = Factory.GetNewChallengeInstance();
            var executedActivity = Factory.GetNewActivityInstance();
            executedActivity.Execute();
            executedActivity.Points = 500;

            challenge.AddActivity(executedActivity);

            Assert.AreEqual(challenge.ExecutedPoints, 500);
        }

        [TestMethod]
        public void MustCalculateEstimatedPoints()
        {
            var challenge = Factory.GetNewChallengeInstance();
            var executedActivity = Factory.GetNewActivityInstance();

            executedActivity.Execute();
            executedActivity.Points = 500;

            var nonExecutedActivity = Factory.GetNewActivityInstance();
            nonExecutedActivity.Points = 500;

            challenge.AddActivity(executedActivity);
            challenge.AddActivity(nonExecutedActivity);

            Assert.AreEqual(challenge.TotalPoints, 1000);
            Assert.AreEqual(challenge.ExecutedPoints, 500);
        }

        [TestMethod]
        public void MustHaveAnId()
        {
            var challenge = Factory.GetNewChallengeInstance();
            Assert.AreNotEqual(challenge.Id.ToString(), string.Empty);
        }


    }
}
