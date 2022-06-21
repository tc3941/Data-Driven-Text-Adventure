using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureDataDriven
{
    class WalkWay : Room
    {
        public WalkWay()
        {
            RoomName = "Gordon Field House WalkWay";
            Details = "You look around for a second and are almost hit by someone on a bike.\nYou notice for a road that doesnt allow bikes and skateboards there does seem to have a lot of them";
            Location = "This is the first stop on the quarter mile coming from the Resident Halls.\nNorth is the Gordon Field House. South is the Wellness Center.\nEast is the Sun Dial. West continues into the school.";
        }
    }
}
