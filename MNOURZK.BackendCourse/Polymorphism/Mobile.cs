using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOURZK.BackendCourse.Basics.Polymorphism
{
    internal class Mobile : Elecetronic
    {
        public int Storage { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Price: {Price}, Color: {Color}, Storage: {Storage}");
        }

        public override void DisplayInfo(string sound)
        {
            Console.WriteLine($"Price: {Price}, Color: {Color}, Storage: {Storage}");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Mobile turn on");
        }

        public override void TurnOn(string sound)
        {
            Console.WriteLine($"Mobile turn on with sound: {sound}");
        }
    }
}
