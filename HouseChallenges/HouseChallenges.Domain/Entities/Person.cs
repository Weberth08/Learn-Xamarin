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

        public void Execute(ActivityExecution activity)
        {
            activity.Execute();
        }

        public void StartActivity(ActivityExecution activity)
        {
            activity.Start();
        }

        public void FinishActivity(ActivityExecution activity)
        {
            activity.Finish();
        }

        public void FinishPartiallyActivity(ActivityExecution activity)
        {
            activity.PerformPartially();
        }

        public void CancelActivity(ActivityExecution activity)
        {
            activity.Cancel();
        }
    }
}
