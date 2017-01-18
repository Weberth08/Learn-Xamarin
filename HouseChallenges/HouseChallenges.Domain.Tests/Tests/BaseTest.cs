using HouseChallenges.Domain.Tests.Factory;

namespace HouseChallenges.Domain.Tests.Tests
{
    public class BaseTest
    {
        public DomainFactory Factory { get; set; }

        public BaseTest()
        {
            Factory = new DomainFactory();
        }
    }
}
