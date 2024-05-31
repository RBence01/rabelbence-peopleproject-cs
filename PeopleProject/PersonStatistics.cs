using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleProject
{
    public class PersonStatistics
    {
        private List<Person> people;

        public PersonStatistics(List<Person> people)
        {
            this.people = people;
        }

        public List<Person> People { get => people; set => people = value; }

        private List<Person> Students => people.Where(e => e.IsStudent).ToList();

        public float GetAverageAge()
        {
            return (float)people.Sum(e => e.Age) / people.Count;
        }
        public int GetNumberOfStudents()
        {
            return people.Count(e => e.IsStudent);
        }
        public Person GetPersonWithHighestScore()
        {
            return people.First(e => e.Score == people.Max(x => x.Score));
        }
        public float GetAverageScoreOfStudents()
        {
            if (Students.Count == 0) return 0;
            return (float)Students.Sum(e => e.Score) / Students.Count;
        }
        public Person GetOldestStudent()
        {
            return Students.First(e => e.Age == Students.Max(x => x.Age));
        }
        public bool IsAnyoneFailing()
        {
            foreach (Person p in people)
            {
                if (p.Score < 40) return true;
            }
            return false;
        }
    }
}
