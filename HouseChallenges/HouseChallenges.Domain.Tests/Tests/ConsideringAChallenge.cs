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

            challenge.AddActivity(Factory.GetNewActivityExecutionInstance());
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
        public void MustHaveAnId()
        {
            var challenge = Factory.GetNewChallengeInstance();
            Assert.AreNotEqual(challenge.Id.ToString(), string.Empty);
        }


    }
}
