using System.Collections.Generic;

namespace HouseChallenges.Domain.Entities
{
    public class HomeTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Activity> Activities { get; set; }
        public ICollection<Person> Executors { get; set; }
        public ICollection<ActivityExecution> ActivitiesExecutions { get; set; }
    }
}
