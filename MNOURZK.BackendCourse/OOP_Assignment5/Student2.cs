using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOURZK.BackendCourse.Basics.OOP_Assignment5
{
    internal class Student2 : Person
    {
        public int Grade { get; set; }
        public override void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}");
        }
    }
}
