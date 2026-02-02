using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOURZK.BackendCourse.Basics
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; private set; }
        public decimal Balance { get; set; } = 0;
        public string StudentId { get; init; }

        public Student() : this("Unknown", 0, "Not Assigned", "0000")
        {
            Console.WriteLine("Default Constructor");
        }

        public Student(string name, int age, string studentId, string grade = "Not Assigned")
        {
            Name = name;
            Age = age;
            Grade = grade;
            StudentId = studentId;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student ID: {StudentId}, Name: {Name}, Age: {Age}, Grade: {Grade}");
        }

        public void UpdateGrade(string newGrade)
        {
            if (!string.IsNullOrWhiteSpace(newGrade))
            {
                Grade = newGrade;                
            }
            else
            {
                Console.WriteLine("Invalid grade. Grade cannot be empty.");
            }
        }
    }
}
