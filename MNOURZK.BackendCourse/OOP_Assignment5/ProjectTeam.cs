using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOURZK.BackendCourse.Basics.OOP_Assignment5
{
    internal class ProjectTeam
    {
        public string TeamName { get; set; }
        Teacher2[] Teachers { get; set; }
        Student2[] Students { get; set; }
        ushort TeacherIndex { get; set; } = 0;
        ushort StudentIndex { get; set; } = 0;

        public ProjectTeam(byte NumberOfTeachers, byte numberOfStudents)
        {
            Teachers = new Teacher2[NumberOfTeachers];
            Students = new Student2[numberOfStudents];
        }

        public void AssignTeacher(Teacher2 teacher)
        {
            Teachers[TeacherIndex] = teacher;
            TeacherIndex++;
        }

        public void AssignStudent(Student2 student)
        {
            Students[StudentIndex] = student;
            StudentIndex++;
        }

        public void GetTeamDetails()
        {
            Console.WriteLine($"Project Team: {TeamName}");
            Console.WriteLine("Teachers:");
            foreach (var teacher in Teachers)
            {
                teacher.GetDetails();
            }
            Console.WriteLine("Students:");
            foreach (var student in Students)
            {
                student.GetDetails();
            }
        }
    }
}
