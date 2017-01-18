using System.Collections.Generic;

namespace HouseChallenges.Domain.Entities
{
    public class HomeTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<Person> Executors { get; set; }
        public virtual ICollection<ActivityExecution> ActivitiesExecutions { get; set; }
    }
}
