using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOURZK.BackendCourse.Basics.Advance_C_
{
    internal struct ComplexStruct
    {
        public int Real { get; set; }
        public int Imagin { get; set; }

        public ComplexStruct()
        {
            Real = 1;
        }

        public void Display()
        {
            Console.WriteLine($"{Real} + {Imagin}i");
        }

        public static bool operator ==( ComplexStruct c1, ComplexStruct c2)
        {
            return c1.Real == c2.Real && c1.Imagin == c2.Imagin;
        }

        public static bool operator !=(ComplexStruct c1, ComplexStruct c2)
        {
            return c1.Real != c2.Real || c1.Imagin != c2.Imagin;
        }
    }
}
