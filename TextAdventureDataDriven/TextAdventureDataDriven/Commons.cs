using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureDataDriven
{
    class Commons : Room
    {
        public Commons()
        {
            RoomName = "The Commons";
            Location = "You're at The Commons. North of here is the parking lot, not really worth visiting.\nEast is the Resident Halls. South is the Sun Dial.";
            Details = "You look around and grab a bit to eat. The food is pretty good in comparison to Gracies. Where are you going next?";
        }
    }
}
