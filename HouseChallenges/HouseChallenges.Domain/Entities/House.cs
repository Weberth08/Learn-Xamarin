using System.Collections.Generic;

namespace HouseChallenges.Domain.Entities
{
    public class House
    {
        protected House()
        {

        }

        public House(string name)
        {
            Name = name;
            Inhabitants = new List<Person>();
            Challenges = new List<ChallengeBase>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Person> Inhabitants { get; set; }
        public virtual ICollection<ChallengeBase> Challenges { get; set; }

        public void AddInhabitant(Person person)
        {
            Inhabitants?.Add(person);
        }

        public void AddChallenge(ChallengeBase challenge)
        {
            Challenges?.Add(challenge);
        }
    }
}
