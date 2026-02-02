using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOURZK.BackendCourse.Basics.Polymorphism
{
    internal abstract class Elecetronic
    {
        public float Price { get; set; }
        public string Color { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Price: {Price}, Color: {Color}");
        }
        public virtual void DisplayInfo(string sound)
        {
            Console.WriteLine($"Price: {Price}, Color: {Color}");
        }

        public abstract void TurnOn();

        public abstract void TurnOn(string sound);
    }
}
