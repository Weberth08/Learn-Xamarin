using HouseChallenges.Domain.Entities;
using HouseChallenges.Domain.Tests.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HouseChallenges.Domain.Tests.Tests
{
    /// <summary>
    /// Summary description for ConsideringAnHouse
    /// </summary>
    [TestClass]
    public class ConsideringAnHouse
    {
        private readonly DomainFactory _factory;
        public ConsideringAnHouse()
        {

            _factory = new DomainFactory();
        }



        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void MustAddAChallenge()
        {
            var house = _factory.GetNewHouseInstance();
            house.AddChallenge(_factory.GetNewChallengeInstance());
            Assert.AreEqual(house.Challenges.Count, 1);

        }

        [TestMethod]
        public void MustAddInhabitant()
        {
            var house = _factory.GetNewHouseInstance();
            house.AddInhabitant(new Person());
            Assert.AreEqual(house.Inhabitants.Count, 1);
        }

        [TestMethod]
        public void MustHaveAName()
        {
            var house = _factory.GetNewHouseInstance();
            Assert.AreNotEqual(house.Name, string.Empty);
        }


    }
}
