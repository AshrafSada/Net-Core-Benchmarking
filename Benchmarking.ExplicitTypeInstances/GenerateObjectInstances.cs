using Benchmarking.ExplicitTypeInstances.Models;

namespace Benchmarking.ExplicitTypeInstances
{
    public class GenerateObjectInstances
    {
        private static List<Student> studentsList;

        public GenerateObjectInstances()
        {
            studentsList = new List<Student>();
        }

        public static Student CreateExplicitStudentInstance()
        {
            Student explicitStd = new Student();

            return explicitStd;
        }

        public static Student CreateImplicitStudentInstance()
        {
            var implicitStd = new Student();

            return implicitStd;
        }

        public static Student CreateImplicitStudentInstanceWithProps()
        {
            var student = new Student
            {
                EnrollmentDate = DateTime.Now.AddDays(-19),
                FirstName = "John",
                LastName = "Doe",
                Id = 1,
                School = new School
                {
                    Id = 101,
                    SchoolName = "John's School",
                    Fees = 1300.00M
                },
                StudentNo = Guid.NewGuid()
            };

            return student;
        }

        public static Student CreateExplicitStudentInstanceWithProps()
        {
            Student student = new Student
            {
                EnrollmentDate = DateTime.Now.AddDays(-19),
                FirstName = "John",
                LastName = "Doe",
                Id = 1,
                School = new School
                {
                    Id = 101,
                    SchoolName = "John's School",
                    Fees = 1300.00M
                },
                StudentNo = Guid.NewGuid()
            };

            return student;
        }

        public static Student AddStudentSimplifiedImplicit()
        {
            var student = new Student
            {
                EnrollmentDate = DateTime.Now.AddDays(-19),
                FirstName = "John",
                LastName = "Doe",
                Id = 1,
                School = new School
                {
                    Id = 101,
                    SchoolName = "John's School",
                    Fees = 1300.00M
                },
                StudentNo = Guid.NewGuid()
            };

            studentsList.Add(student);
            return student;
        }

        public static Student AddStudentSimplifiedExplicit()
        {
            Student student = new Student
            {
                EnrollmentDate = DateTime.Now.AddDays(-19),
                FirstName = "John",
                LastName = "Doe",
                Id = 1,
                School = new School
                {
                    Id = 101,
                    SchoolName = "John's School",
                    Fees = 1300.00M
                },
                StudentNo = Guid.NewGuid()
            };

            studentsList.Add(student);

            return student;
        }

        public static Student AddStudentNotSimplifiedImplicit()
        {
            var student = new Student();

            student.EnrollmentDate = DateTime.Now.AddDays(-19);
            student.FirstName = "John";
            student.LastName = "Doe";
            student.Id = 1;
            student.School = new School { Id = 101, SchoolName = "John's School", Fees = 1300.00M };
            student.StudentNo = Guid.NewGuid();

            studentsList.Add(student);

            return student;
        }

        public static Student AddStudentNotSimplifiedExplicit()
        {
            Student student = new Student();

            student.EnrollmentDate = DateTime.Now.AddDays(-19);
            student.FirstName = "John";
            student.LastName = "Doe";
            student.Id = 1;
            student.School = new School { Id = 101, SchoolName = "John's School", Fees = 1300.00M };
            student.StudentNo = Guid.NewGuid();

            studentsList.Add(student);

            return student;
        }

        // create instance with constructor as expression body
        public static Teacher CreateTeacher()
        {
            return new Teacher();
        }

        // create instance with constructor as code block
        public static Specialization CreateSpecialization()
        {
            return new Specialization();
        }
    }
}
