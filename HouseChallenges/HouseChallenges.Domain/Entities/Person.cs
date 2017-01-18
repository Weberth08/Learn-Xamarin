using HouseChallenges.Domain.Entities.Interfaces;

namespace HouseChallenges.Domain.Entities
{
    public class Person
    {
        protected Person()
        {

        }

        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public void Execute(IActivityExecutionBase activity)
        {
            activity.Execute();
        }

        public void StartActivity(IActivityExecutionBase activity)
        {
            activity.Start();
        }

        public void FinishActivity(IActivityExecutionBase activity)
        {
            activity.Finish();
        }

        public void FinishPartiallyActivity(IActivityExecutionBase activity)
        {
            activity.PerformPartially();
        }

        public void CancelActivity(IActivityExecutionBase activity)
        {
            activity.Cancel();
        }
    }
}
