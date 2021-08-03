using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            var studentInstance = new Student
            {
                Name = "Amy",
                StudentId = 1,
                NumberOfCredits = 1,
                Gpa = 4.0
            };

            var courseInstance = new Course
            {
                //CourseInfo = new Dictionary<int, string> 
                //{ 
                //    [123] = "C#"
                //},
                Students = new List<Student> { studentInstance },
                CourseDescription = "C# Web Development covers building applications with ASP.NET. This module also covers object-oriented principles.",
                Location = "online"
            };

            var teacherInstance = new Teacher
            {
                FirstName = "Scott",
                LastName = "Kuhl",
                Subject = "C#",
                YearsTeaching = 10,
            };

            studentInstance.Print();
            courseInstance.Print();
            teacherInstance.Print();


        }
    }
}
