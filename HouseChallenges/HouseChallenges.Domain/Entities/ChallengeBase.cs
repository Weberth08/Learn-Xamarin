using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseChallenges.Domain.Entities
{
    public class ChallengeBase
    {
        protected ChallengeBase()
        {

        }

        public ChallengeBase(string name, DateTime startDate, DateTime endDate)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            Activities = new List<Activity>();
            People = new List<Person>();

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Activity> Activities { get; set; }
        public List<Person> People { get; set; }

        public int TotalPoints => Activities.Sum(activity => activity.Points);

        public int ExecutedPoints => Activities.Where(activity => activity.Executed).Sum(activity => activity.Points);

        public void AddActivity(Activity activity) => Activities?.Add(activity);

        public void AddParticipant(Person person) => People?.Add(person);
    }
}
