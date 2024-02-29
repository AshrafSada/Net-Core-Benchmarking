namespace Benchmarking.PrimaryConstructor
{
    public class Person
    {
        private readonly Guid id;

        public Person(string name, int age, string address)
        {
            id = Guid.NewGuid();
            Name = name;
            Age = age;
            Address = address;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Address { get; private set; }
    }
}
