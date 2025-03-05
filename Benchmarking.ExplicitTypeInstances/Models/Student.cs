namespace Benchmarking.ExplicitTypeInstances.Models
{
    public class Student
    {
        public int Id { get; set; }
        public Guid StudentNo { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public School School { get; set; }
    }
}
