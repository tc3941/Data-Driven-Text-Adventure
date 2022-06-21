using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureDataDriven
{
    class SAU : Room
    {
        public SAU()
        {
            RoomName = "Student Center";
            Details = "There is not much to do here but there is a gumball dispenser.\nYou start to chew the gumball but the flavor quickly fades.";
            Location = "This is the Student Center. North is the walkway.\nContinue across and you'll find the Gym where people play sports.";
        }
    }
}
