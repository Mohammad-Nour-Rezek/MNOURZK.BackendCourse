using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOURZK.BackendCourse.Basics.OOP_Assignment5
{
    internal class Teacher2 : Person
    {
        public string Subject { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Subject: {Subject}");
        }
    }
}
