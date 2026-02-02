using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOURZK.BackendCourse.Basics.Advance_C_
{
    // from ref to val
    // internal struct Complex
    internal class Complex
    {
        public int Real { get; set; }
        public int Imagin { get; set; }
        //public int Real { get; private set; }
        //public int Imagin { get; private set; }
        public static int Counter { get; set; } = 0;

        //public Complex() : this(0, 0) { }
        static Complex() // Static constructor
        {
            //Real = 10; // Error: A static constructor cannot access instance members
            Counter = 0;
        }
        public Complex(int a = 0, int b = 0)
        {
            Real = a;
            Imagin = b;
            Counter++;
        }

        //public static Complex operator +(Complex c1, Complex c2)
        //{
        //    return new Complex(c1.Real + c2.Real, c1.Imagin + c2.Imagin);
        //}

        public static Complex operator +(Complex complex1, Complex complex2) 
        {
            return new Complex(complex1.Real + complex2.Real, complex1.Imagin + complex2.Imagin);
        }

        public static bool operator >(Complex c1, Complex c2)
        {
            return (c1.Real * c1.Real + c1.Imagin * c1.Imagin) > (c2.Real * c2.Real + c2.Imagin * c2.Imagin);
        }

        public static bool operator <(Complex c1, Complex c2)
        {
            return (c1.Real * c1.Real + c1.Imagin * c1.Imagin) < (c2.Real * c2.Real + c2.Imagin * c2.Imagin);
        }

        //public static bool operator ==(Complex c1, Complex c2)
        //{
        //    return (c1.Real == c2.Real) && (c1.Imagin == c2.Imagin);
        //}

        //public static bool operator !=(Complex c1, Complex c2)
        //{
        //    return !(c1 == c2);
        //}

        public void Display()
        {
            Console.WriteLine($"{Real} + {Imagin}i");
        }

        public static void DisplayCounter()
        {
            //this.Real; // Error: A static member cannot access instance members directly
            Complex c = new Complex();
            c.Real = 15; // OK: Accessing instance member through an instance
            Console.WriteLine($"Number of created complex numbers: {Counter}");
        }

        public override string ToString()
        {
            return $"{Real + Imagin}i";
        }

        // we will call it like c1.Equals(c2)
        // Here Equals(object? obj) <== object? obj is polymorphism,
        // so it can accept any type of object
        public override bool Equals(object? obj)
        {
            //Complex? c = obj as Complex;
            //return c is null ? false : Real == c.Real && Imagin == c.Imagin;
            return obj is Complex c && Real == c.Real && Imagin == c.Imagin;
            //return obj is Complex { Real: var r, Imagin: var i } && Real == r && Imagin == i;

            // Compare references syntax
            //if (obj is Complex c)
            //{
            //    //return this == c;
            //    return Real == c.Real && Imagin == c.Imagin;
            //}

            //return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Real, Imagin);
        }

        // Deep Copy
        // c1.Clone();
        public Complex Clone()
        {
            return new Complex(Real, Imagin);
        }

        public Complex ShallowCopy()
        {
            return (Complex)base.MemberwiseClone(); // unboxing upcast
        }
    }
}
