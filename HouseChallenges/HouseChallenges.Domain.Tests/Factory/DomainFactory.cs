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

        public Activity GetNewActivityInstance()
        {
            return new Activity("atividade", 500);
        }

        public ActivityExecution GetNewActivityExecutionInstance()
        {
            return new ActivityExecution(GetNewPersonInstance(), GetNewActivityInstance());
        }

        internal ActivityExecution GetNewActivityExecutionInstance(Person executor)
        {
            return new ActivityExecution(executor, GetNewActivityInstance());
        }
    }
}
