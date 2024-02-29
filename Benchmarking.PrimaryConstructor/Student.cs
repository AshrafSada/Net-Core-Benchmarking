namespace Benchmarking.PrimaryConstructor
{
    public class Student(string name, int age, string address)
    {
        private static readonly Guid id = Guid.NewGuid();
        public string Name { get; private set; } = name;
        public int Age { get; private set; } = age;
        public string Address { get; private set; } = address;
    }
}
