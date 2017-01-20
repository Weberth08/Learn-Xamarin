using System;
using System.Collections.Generic;

namespace HouseChallenges.Domain.Entities
{
    public class Activity
    {
        protected Activity()
        {

        }

        public Activity(string name, int points)
        {
            Name = name;
            Points = points;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        private int _points;
        public int Points
        {
            get { return _points; }
            set
            {
                if (value < 0) throw new ArgumentException("Points value must be greater than 0.");
                _points = value;
            }
        }

        protected virtual IEnumerable<ActivityExecution> ActivityExecutions { get; set; }
    }
}
