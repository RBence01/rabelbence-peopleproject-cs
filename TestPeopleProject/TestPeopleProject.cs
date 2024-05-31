using PeopleProject;

namespace TestPeopleProject
{
    public class Tests
    {
        private PersonStatistics ps;
        [SetUp]
        public void Setup()
        {
            List<Person> lst = new List<Person>() { new Person(1, "Bob", 32, true, 100), new Person(2, "Andris", 11, false, 0), new Person(3, "Sándor", 2, true, 69)};
            ps = new PersonStatistics(lst);
        }

        [Test]
        public void TestGetAverageAge()
        {
            Assert.That(ps.GetAverageAge() == 45f / 3);
        }

        [Test]
        public void TestGetNumberOfStudents()
        {
            Assert.That(ps.GetNumberOfStudents() == 2);
        }

        [Test]
        public void TestGetPersonWithHighestScore()
        {
            Assert.That(ps.GetPersonWithHighestScore() == ps.People.First());
        }

        [Test]
        public void TestGetAverageScoreOfStudents()
        {
            Assert.That(ps.GetAverageScoreOfStudents() == 169f / 2);
        }

        [Test]
        public void TestGetOldestStudent()
        {
            Assert.That(ps.GetOldestStudent() == ps.People.First());
        }

        [Test]
        public void TestIsAnyoneFailing()
        {
            Assert.That(ps.IsAnyoneFailing() == true);
        }
    }
}