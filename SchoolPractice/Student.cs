using System;
using System.Collections.Generic;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public void Print()
        {
            Console.WriteLine($"***Student Info***\n Name: {Name}\n Student ID: {StudentId}\n Number of Credits: {NumberOfCredits}\n GPA: {Gpa}\n");
        }
    }

    public class Course
    {
        //public Dictionary<int, string> CourseInfo = new Dictionary<int, string>();
        public List<Student> Students { get; set; }
        public string CourseDescription;
        public string Location;

        public void Print()
        {
            Console.WriteLine($"***Course Info***\n Student info: {Students}\n Course Description: {CourseDescription}\n Location: {Location}\n");
        }
    }



    public class Teacher
    {
        public string FirstName;
        public string LastName;
        public string Subject;
        public int YearsTeaching;

        public void Print()
        {
            Console.WriteLine($"***Teacher Info***\n First Name: { FirstName}\n Last Name: {LastName}\n Subject: {Subject}\n Years Teaching: {YearsTeaching}");
        }
    }
}
