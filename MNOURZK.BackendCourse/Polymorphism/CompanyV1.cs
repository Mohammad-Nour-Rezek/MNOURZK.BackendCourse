using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOURZK.BackendCourse.Basics.Polymorphism
{
    internal class CompanyV1
    {
        // the code here is not scalable and not designed good
        // 1st problem, the code is open to extend closed to modify principle is violated
        // 2nd problem, if we need to add or remove another electronic type we need to modify this class


        Mobile[] mobile = new Mobile[10];
        Tablet[] tablet = new Tablet[10];
        Laptop[] laptop = new Laptop[10];

        ushort mobileCounter = 0;
        ushort tabletCounter = 0;
        ushort laptopCounter = 0;

        public void AddMobile(Mobile mobile)
        {
            this.mobile[mobileCounter++] = mobile;
            //mobileCounter++;
        }
        public void AddTablet(Tablet tablet)
        {
            this.tablet[tabletCounter++] = tablet;
            //tabletCounter++;
        }
        public void AddLaptop(Laptop laptop)
        {
            this.laptop[laptopCounter++] = laptop;
        }

        public void DisplayAllElectronics()
        {
            Console.WriteLine("Mobiles:");
            for (int i = 0; i < mobileCounter; i++)
            {
                mobile[i].DisplayInfo();
            }
            Console.WriteLine("\nTablets:");
            for (int i = 0; i < tabletCounter; i++)
            {
                tablet[i].DisplayInfo();
            }
            Console.WriteLine("\nLaptops:");
            for (int i = 0; i < laptopCounter; i++)
            {
                laptop[i].DisplayInfo();
            }
        }
    }
}
