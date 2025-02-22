using System;

namespace Benchmarking.ExcplicitTypeInsatnces.Models
{
    public class Teacher
    {
        private readonly DateTimeOffset currentDateTime;
        public Teacher()
        {
            currentDateTime = DateTime.UtcNow;
        }


        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Specialization Specialization { get; set; }

    }
}