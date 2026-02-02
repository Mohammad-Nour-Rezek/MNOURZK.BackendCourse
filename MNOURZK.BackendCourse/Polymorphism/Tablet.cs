using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOURZK.BackendCourse.Basics.Polymorphism
{
    internal class Tablet : Mobile
    {
        public bool WithPen { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Price: {Price}, Color: {Color}, Storage: {Storage}, Has pen: {WithPen}");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Tablet turn on");
        }
    }
}
