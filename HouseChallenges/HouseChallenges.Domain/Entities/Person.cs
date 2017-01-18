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
    }
}
