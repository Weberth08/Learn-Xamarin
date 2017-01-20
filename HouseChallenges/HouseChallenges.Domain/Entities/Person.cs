using HouseChallenges.Domain.Entities.Interfaces;

namespace HouseChallenges.Domain.Entities
{
    public class Person
    {
        protected Person()
        {

        }

        public int Id { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public void Execute(IActivityExecutionBase activity)
        {
            activity.Execute(this);
        }

        public void StartActivity(IActivityExecutionBase activity)
        {
            activity.Start(this);
        }

        public void FinishActivity(IActivityExecutionBase activity)
        {
            activity.Finish(this);
        }

        public void FinishPartiallyActivity(IActivityExecutionBase activity)
        {
            activity.PerformPartially(this);
        }

        public void CancelActivity(IActivityExecutionBase activity)
        {
            activity.Cancel(this);
        }


        public override bool Equals(object obj)
        {
            return Equals((Person)obj);
        }

        protected bool Equals(Person other)
        {
            return Id == other.Id && string.Equals(Name, other.Name);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Id * 397) ^ (Name != null ? Name.GetHashCode() : 0);
            }
        }
    }
}
