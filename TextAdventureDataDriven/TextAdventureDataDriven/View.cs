using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureDataDriven
{
    class View
    {

        public static View singleTon = new View();

        public static View getInstance()
        {
            return singleTon;
        }


        string roomLocation,roomDescription, ending = "Ended, hope you enjoyed your RIT experience.\nEnter anything to close the program.";
        string LOOP_QUESTION = "What would you like to do? Look? Or go North, East, South, West? Or Quit?";

        public string roomDetails
        {
            get
            {
                return roomDescription;
            }
            set
            {
                roomDescription = value;
            }
        }
        public string RoomLocation
        {
            get
            {
                return roomLocation;
            }
            set
            {
                roomLocation = value;
            }
        }
        public void printLocation()
        {
            Console.WriteLine(roomLocation);
        }
        public void printToScreen()
        {
            Console.WriteLine(roomDescription);
        }
        public void printLoop()
        {
            Console.WriteLine('\n' + LOOP_QUESTION);
        }
        public void GetRoomDetails(MyKeyValuePair<string> room)
        {
            roomDetails = room.GetValue2();
            RoomLocation = room.GetValue1();
        }
        public void printQuit()
        {
            Console.WriteLine(ending);
        }

    }
}
