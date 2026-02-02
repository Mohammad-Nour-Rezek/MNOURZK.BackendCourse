using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOURZK.BackendCourse.Basics.Composition
{
    internal class House
    {
        ushort Size { get; set; } = 0;
        public string Address { get; set; }
        Room[] Rooms { get; set; }

        public House(ushort _size = 3)
        {            
            Rooms = new Room[_size];
        }

        public void AddRoom(string type, float area)
        {
            if(Size < Rooms.Length)
            {
                Rooms[Size] = new Room() { Type = type, Area = area };
                Size++;
            }
            else
                Console.WriteLine("Room number exceeds the size of the house rooms.");
        }

        public void DisplayHouseInfo()
        {
            Console.WriteLine($"House Address: {Address}");
            foreach (var room in Rooms)
            {
                room?.DisplayRooms();
            }
        }
    }
}
