using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureDataDriven
{
    class WalkWay2 : Room
    {
        public WalkWay2()
        {

            RoomName = "Student Center WalkWay";
            Details = "You look around and notice that several people are looking at you.\nMaybe standing in the middle of a walkway and just looking around isnt the best idea";
            Location = "This is the walkway that seperates the Gym and Student Center, hence the name.\nNorth is the Gym. South is the Student Center and East is the other walkway.";
        }
    }
}
