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
    }
}
