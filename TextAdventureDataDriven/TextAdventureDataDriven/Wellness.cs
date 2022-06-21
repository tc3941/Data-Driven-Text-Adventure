using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureDataDriven
{
    class Wellness : Room
    {
        public Wellness()
        {
            RoomName = "The Wellness Center";
            Location = "This is the place where most student comes to get therapy and pick up their medicine.\nNorth is the Walkway and across from it is the Gordon Field house.";
            Details = "You look around and notice there is way too many people in here right now. Maybe you should come back later.";
        }
    }
}
