using System;

namespace Benchmarking.SwitchVsIfElse
{
    public class SampleCode
    {
        public static int ValidateEmployeeIfElse(Employee employee)
        {
            if (employee is null)
            {
                throw new NullReferenceException("Employee is Null");
            }
            else if (IsInvalid(employee.Name))
            {
                throw new InvalidEmployeeException(nameof(Employee.Name), employee.Name);
            }

            return 0;
        }

        public static int ValidateEmployeeSwitch(Employee employee)
        {
            switch (employee)
            {
                case null:
                    throw new NullReferenceException("Employee is Null");
                case { } when IsInvalid(employee.Name):
                    throw new InvalidEmployeeException(nameof(Employee.Name), employee.Name);
            }

            return 0;
        }

        private static bool IsInvalid(string name)
        {
            return name == String.Empty;
        }
    }

    public class Employee
    {
        public string Name { get; internal set; }
    }

    public class InvalidEmployeeException : Exception
    {
        public InvalidEmployeeException() : base()
        {
        }

        public InvalidEmployeeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public InvalidEmployeeException(string attributeName, object attributeValue)
            : base($"Invalid Attribute {attributeName} Value {attributeValue}")
        {
        }
    }
}
