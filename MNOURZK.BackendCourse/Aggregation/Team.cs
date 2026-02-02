using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNOURZK.BackendCourse.Basics.Aggregation
{
    internal class Team
    {
        Player[] Players;

        public Player this[int index]
        {
            get { return Players[index]; }
            set { Players[index] = value; }
        }

        // if we did this then will be composition
        public Team(Player[] players)
        {
            //Players = new Player[_size];
            Players = players;
        }
    }
}
