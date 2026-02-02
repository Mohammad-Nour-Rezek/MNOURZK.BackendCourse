using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOURZK.BackendCourse.Basics.Inheritance
{
    internal class Rectangle : Shape
    {
        public int Thickness { get; set; }
        public int Dim2 { get; set; } = 44;

        public Rectangle() : base(10)
        {
            Console.WriteLine("Rectangle Constructor Call");
        }

        public void Draw()
        {
            base.Dim2 = 5; // Accessing the inherited public property Dim2 from Shape class
            Console.WriteLine($"Drawing a rectangle with thickness: {Thickness}");
            Console.WriteLine($"its parent dimentions are: {base.Dim2}");
            Console.WriteLine($"its parent dimentions are: {this.Dim2}");
        }
    }
}
