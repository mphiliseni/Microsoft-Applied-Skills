using System;

namespace StudentAttendance
{
    public class Student
    {
        // TODO Task 2.1: Make FirstName, MiddleName, and LastName modifiable only inside this class
        public string firstname { get; private set; }

        // TODO Task 2.2: Allow MiddleName to be null
        public string? middlename { get; private set; }
        // End of TODO Task 2.2

        public string lastname { get; private set; }
        // End of TODO Task 2.1

        // Full constructor
        public Student(string first, string middle, string last)
        {
            firstname = first;
            middlename = middle;
            lastname = last;
        }

        // TODO Task 2.3: Add constructor with only FirstName and LastName
        public Student(string first, string last)
        {
            firstname = first;
            lastname = last;
            middlename = null;
        }
        // End of TODO Task 2.3
    }

}
