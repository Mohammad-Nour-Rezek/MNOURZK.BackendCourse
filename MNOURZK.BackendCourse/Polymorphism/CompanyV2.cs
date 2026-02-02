using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOURZK.BackendCourse.Basics.Polymorphism
{
    internal class CompanyV2
    {
        // the code here is scalable and designed good
        // 1st problem, the code is open to extend closed to modify principle is followed
        // 2nd problem, if we need to add or remove another electronic type we don't need to modify this class
        Elecetronic[] electronics = new Elecetronic[30];
        ushort electronicCounter = 0;
        // we can pass any electronic type to this method, using polymorphism
        public void AddElectronic(Elecetronic electronic)
        {
            this.electronics[electronicCounter++] = electronic;
        }
        // we can display any electronic type in this method, using polymorphism
        // because DisplayInfo is vertual and overridden in each derived class
        public void DisplayAllElectronics()
        {
            Console.WriteLine("Electronics:");
            for (int i = 0; i < electronicCounter; i++)
            {
                electronics[i].DisplayInfo();
            }
        }

        public void FilterMobile(float price) 
        {
            for (int i = 0; i < electronicCounter; i++)
            {
                if (electronics[i] is Mobile m)
                {
                    if (m.Price == price)
                    {
                        m.DisplayInfo();
                    }
                }                
            }
        }
    }
}
