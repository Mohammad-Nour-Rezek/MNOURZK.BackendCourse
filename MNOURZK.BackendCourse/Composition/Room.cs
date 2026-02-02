using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOURZK.BackendCourse.Basics.Composition
{
    internal class Room
    {
        public float Area { get; set; }
        public string Type { get; set; }

        public void DisplayRooms()
        {
            Console.WriteLine($"Room Type: {Type}, Area: {Area} sqm");
        }
    }
}
