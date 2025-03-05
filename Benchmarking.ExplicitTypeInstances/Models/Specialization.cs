namespace Benchmarking.ExplicitTypeInstances.Models
{
    public class Specialization
    {
        private readonly DateTimeOffset currentDateTime;

        public Specialization() => currentDateTime = DateTime.UtcNow;

        public int Id { get; set; }

        public string Subject { get; set; }
    }
}
