using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureDataDriven
{
    class Gym : Room
    {
        public Gym()
        {
            RoomName = "Gym";
            Location = "This is the Gym where people come and play sports of all kinds and work out.\nSouth of here is the student center walkway.";
            Details = "You look around and notice some people playing volley ball. Not sure who is winning but there seems to be a decent size squad.";
        }
    }
}
