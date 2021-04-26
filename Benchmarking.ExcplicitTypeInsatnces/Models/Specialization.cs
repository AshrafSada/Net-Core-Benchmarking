using System;

namespace Benchmarking.ExcplicitTypeInsatnces
{
    public class Specialization
    {
        private readonly DateTimeOffset currentDateTime;

        public Specialization() => currentDateTime = DateTime.UtcNow;

        public int Id { get; set; }

        public string Subject { get; set; }
    }
}
