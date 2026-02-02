using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOURZK.BackendCourse.Basics.Inheritance
{
    internal class Square : Rectangle
    {
        public int SquareProp { get; set; }

        public Square()
        {
            Console.WriteLine("Square Constructor Call");
        }

        public void DrawSquare()
        {
            Console.WriteLine("Drawing a square");
            Console.WriteLine($"its dimentions are: {Dim2}");
        }
    }
}
