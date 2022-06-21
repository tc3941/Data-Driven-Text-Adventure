using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureDataDriven
{
    class ResidentHall : Room
    {
        public ResidentHall()
        {
            RoomName = "Resident Halls";
            Location = "This is the Resident Halls. Freshmen galor.\nWest of here is the Sun Dial.";
            Details = "You look around and notice all of the windows only open a few inches.\nWeird I wonder why they would need such windows at a college.";
        }
    }
}
