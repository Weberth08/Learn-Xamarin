using FluentValidator.Validation;
using System.Collections.Generic;

namespace HouseChallenges.Domain.Entities
{
    public class Activity : BaseEntity
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

        private string _name;
        public string Name
        {
            get { return _name; }
            private set
            {
                _name = value;
                new ValidationContract<Activity>(this).
                    IsRequired(x => x.Name);
            }
        }

        private int _points;
        public int Points
        {
            get { return _points; }
            set
            {
                _points = value;
                new ValidationContract<Activity>(this).IsGreaterThan(x => x.Points, 0);

            }
        }

        protected virtual IEnumerable<ActivityExecution> ActivityExecutions { get; set; }
    }
}
