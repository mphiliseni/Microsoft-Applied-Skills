using System;

namespace StudentAttendance
{
    public class Student
    {
        // TODO Task 2.1: Make FirstName, MiddleName, and LastName modifiable only inside this class
        public string FirstName { get; private set; }

        // TODO Task 2.2: Allow MiddleName to be null
        public string? MiddleName { get; private set; }
        // End of TODO Task 2.2

        public string LastName { get; private set; }
        // End of TODO Task 2.1

        // Full constructor
        public Student(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        // TODO Task 2.3: Add constructor with only FirstName and LastName
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = null;
        }
        // End of TODO Task 2.3
    }

}
