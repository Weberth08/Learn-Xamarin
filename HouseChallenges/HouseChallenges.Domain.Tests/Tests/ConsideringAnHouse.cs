using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HouseChallenges.Domain.Tests.Tests
{
    /// <summary>
    /// Summary description for ConsideringAnHouse
    /// </summary>
    [TestClass]
    public class ConsideringAnHouse : BaseTest
    {

        public ConsideringAnHouse()
        {


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
            var house = Factory.GetNewHouseInstance();
            house.AddChallenge(Factory.GetNewChallengeInstance());
            Assert.AreEqual(house.Challenges.Count, 1);

        }

        [TestMethod]
        public void MustAddInhabitant()
        {
            var house = Factory.GetNewHouseInstance();
            house.AddInhabitant(Factory.GetNewPersonInstance());
            Assert.AreEqual(house.Inhabitants.Count, 1);
        }

        [TestMethod]
        public void MustHaveAName()
        {
            var house = Factory.GetNewHouseInstance();
            Assert.AreNotEqual(house.Name, string.Empty);
        }


    }
}
