using System;
using StudentAttendance;

namespace StudentAttendance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Task 2.4: Create an instance of Student with sample values
            Student student = new Student("Ben", "Sam", "Smith");
            Console.WriteLine($"Student Name: {student.FirstName} {student.MiddleName} {student.LastName}");
            // End of TODO Task 2.4
        }
    }

}
