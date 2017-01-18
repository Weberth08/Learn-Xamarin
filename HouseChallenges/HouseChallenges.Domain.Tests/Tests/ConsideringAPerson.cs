using HouseChallenges.Domain.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            var activity = Factory.GetNewActivityInstance();
            Assert.AreEqual(false, activity.Executed);

            person.Execute(activity);
            Assert.AreEqual(true, activity.Executed);

        }

        [TestMethod]
        public void MustStartAndFinishAnActivity()
        {
            var person = Factory.GetNewPersonInstance();
            var activity = Factory.GetNewActivityInstance();
            Assert.AreEqual(true, activity.Status == ActivityStatus.NoStarted);

            person.StartActivity(activity);
            Assert.AreEqual(true, activity.Status == ActivityStatus.InProgress);

            person.FinishActivity(activity);
            Assert.AreEqual(true, activity.Status == ActivityStatus.Executed);

        }
    }

}
