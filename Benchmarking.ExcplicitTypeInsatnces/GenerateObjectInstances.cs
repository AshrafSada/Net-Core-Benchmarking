using Benchmarking.ExcplicitTypeInsatnces.Models;
using System;
using System.Collections.Generic;

namespace Benchmarking.ExcplicitTypeInsatnces
{
    internal static class GenerateObjectInstances
    {
        private static List<Student> studentsList;

        internal static Student CreateExplicitStudentInstance()
        {
            Student explicitStd = new Student();

            return explicitStd;
        }

        internal static Student CreateImplicitStudentInstance()
        {
            var implicitStd = new Student();

            return implicitStd;
        }

        internal static Student CreateImplicitStudentInstanceWithProps()
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

        internal static Student CreateExplicitStudentInstanceWithProps()
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

        internal static bool AddStudentSimplifiedImplicit()
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
            return true;
        }

        internal static bool AddStudentSimplifiedExplicit()
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

            return true;
        }

        internal static bool AddStudentNotSimplifiedImplicit()
        {
            var student = new Student();

            student.EnrollmentDate = DateTime.Now.AddDays(-19);
            student.FirstName = "John";
            student.LastName = "Doe";
            student.Id = 1;
            student.School = new School { Id = 101, SchoolName = "John's School", Fees = 1300.00M };
            student.StudentNo = Guid.NewGuid();

            studentsList.Add(student);

            return true;
        }

        internal static bool AddStudentNotSimplifiedExplicit()
        {
            Student student = new Student();

            student.EnrollmentDate = DateTime.Now.AddDays(-19);
            student.FirstName = "John";
            student.LastName = "Doe";
            student.Id = 1;
            student.School = new School { Id = 101, SchoolName = "John's School", Fees = 1300.00M };
            student.StudentNo = Guid.NewGuid();

            studentsList.Add(student);

            return true;
        }
    }
}
