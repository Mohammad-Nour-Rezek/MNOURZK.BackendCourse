using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOURZK.BackendCourse.Basics.OOP_Assignment5
{
    internal class ProjectTeamV2
    {
        public Person[] Person { get; set; }
        ushort Index { get; set; } = 0;

        public ProjectTeamV2(ushort numberOfPersons = 2)
        {
            Person = new Person[numberOfPersons];
        }

        public void AssignPerson(Person person)
        {
            Person[Index++] = person;
        }

        public void GetTeamDetails()
        {
            Console.WriteLine($"Project Team Details:");
            Console.WriteLine("Teachers:");
            foreach (var person in Person)
            {
                if (person is Teacher2)
                {
                    person.GetDetails();
                }
            }

            Console.WriteLine("Students:");
            foreach (var person in Person)
            {
                if (person is Student2)
                {
                    person.GetDetails();
                }
            }
        }
    }
}
