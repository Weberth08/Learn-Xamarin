using HouseChallenges.Domain.Entities;
using System;

namespace HouseChallenges.Domain.Tests.Factory
{
    public class DomainFactory
    {
        public House GetNewHouseInstance()
        {
            return new House("Sweet Home");
        }

        public ChallengeBase GetNewChallengeInstance()
        {
            return new ChallengeBase("Test", DateTime.Now, DateTime.Now);
        }

        public Person GetNewPersonInstance()
        {
            return new Person("Person 01");
        }

        public ActivityExecution GetNewActivityExecutionInstance()
        {
            return new ActivityExecution();
        }
    }
}
