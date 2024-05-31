namespace PeopleProject
{
    public class Person
    {
        private uint id;
        private string name;
        private uint age;
        private bool isStudent;
        private uint score;

        public Person(uint id, string name, uint age, bool isStudent, uint score)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.isStudent = isStudent;
            this.score = score;
        }

        public uint Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public uint Age { get => age; set => age = value; }
        public bool IsStudent { get => isStudent; set => isStudent = value; }
        public uint Score { get => score; set => score = value; }
    }
}
