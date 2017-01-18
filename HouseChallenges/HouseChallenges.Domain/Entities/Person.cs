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

        public void Execute(Activity activity)
        {
            activity.Execute();
        }

        public void StartActivity(Activity activity)
        {
            activity.Start();
        }

        public void FinishActivity(Activity activity)
        {
            activity.Finish();
        }

        public void FinishPartiallyActivity(Activity activity)
        {
            activity.PerformPartially();
        }

        public void CancelActivity(Activity activity)
        {
            activity.Cancel();
        }
    }
}
