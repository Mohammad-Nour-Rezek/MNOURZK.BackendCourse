using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOURZK.BackendCourse.Basics.Inheritance
{
    internal class Shape
    {
        private int Dim1 { get; set; } = 1;
        public int Dim2 { get; set; }
        public string Color { get; set; }

        public Shape()
        {
            Console.WriteLine("Shape Constructor Call");
        }

        public Shape(int dim1)
        {
            Dim1 = dim1;
            Console.WriteLine($"Shape Constructor with parameter {Dim1} Call");
        }

        public float Area()
        {
            return Dim1 * Dim2;
        }

        public void Display()
        {
            Console.WriteLine($"Shape Color: {Color}, Area: {Area()}");
        }
    }
}
