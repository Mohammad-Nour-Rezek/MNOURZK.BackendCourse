using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOURZK.BackendCourse.Basics.Polymorphism
{
    internal class Laptop : Elecetronic
    {
        public string Model { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Price: {Price}, Color: {Color}, Model: {Model}");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Laptop turn on");
        }

        public override void TurnOn(string sound)
        {
            Console.WriteLine("Laptop turned on using a button");
        }
    }
}
