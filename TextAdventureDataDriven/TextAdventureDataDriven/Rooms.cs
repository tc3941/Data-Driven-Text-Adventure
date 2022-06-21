using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureDataDriven
{
    class Rooms
    {
        List<MyKeyValuePair<string>> rooms = new List<MyKeyValuePair<string>>();
        int currentRoomIndex = 0;
        public static Rooms singeTon = new Rooms();

        public MyKeyValuePair<string> currentRoom
        {
            get
            {
                return rooms[currentRoomIndex];
            }
        }
        public string RoomName
        {
            get
            {
                return rooms[currentRoomIndex].GetKey();
            }
        }
        public string Location
        {
            get
            {
                return rooms[currentRoomIndex].GetValue1();
            }
        }
        public string Details
        {
            get
            {
                return rooms[currentRoomIndex].GetValue2();
            }
        }
        public string North
        {
            get
            {
                if (rooms[currentRoomIndex].GetValue3().Length != 0)
                    return rooms[currentRoomIndex].GetValue3().Substring(0, rooms[currentRoomIndex].GetValue3().IndexOf(','));
                else
                    return "";
            }
        }
        public string NorthTransition
        {
            get
            {
                return rooms[currentRoomIndex].GetValue3().Substring(rooms[currentRoomIndex].GetValue3().IndexOf(',')+2);
            }
        }
        public string East
        {
            get
            {
                if (rooms[currentRoomIndex].GetValue4().Length != 0)
                    return rooms[currentRoomIndex].GetValue4().Substring(0, rooms[currentRoomIndex].GetValue4().IndexOf(','));
                else
                    return "";
            }
        }
        public string EastTransition
        {
            get
            {
                return rooms[currentRoomIndex].GetValue4().Substring(rooms[currentRoomIndex].GetValue4().IndexOf(',') + 2);
            }
        }
        public string South
        {
            get
            {
                if (rooms[currentRoomIndex].GetValue5().Length != 0)
                    return rooms[currentRoomIndex].GetValue5().Substring(0, rooms[currentRoomIndex].GetValue5().IndexOf(','));
                else
                    return "";
            }
        }
        public string SouthTransition
        {
            get
            {
                return rooms[currentRoomIndex].GetValue5().Substring(rooms[currentRoomIndex].GetValue5().IndexOf(',') + 2);
            }
        }
        public string West
        {
            get
            {
                if (rooms[currentRoomIndex].GetValue6().Length != 0)
                    return rooms[currentRoomIndex].GetValue6().Substring(0, rooms[currentRoomIndex].GetValue6().IndexOf(','));
                else
                    return "";
            }
        }
        public string WestTransition
        {
            get
            {
                return rooms[currentRoomIndex].GetValue6().Substring(rooms[currentRoomIndex].GetValue6().IndexOf(',') + 2);
            }
        }

        public Rooms()
        {

        }
        public Rooms(List<MyKeyValuePair<string>> r1)
        {
            setRooms(rooms);
        }

        public static Rooms getInstance()
        {
            return singeTon;
        }
        public void setRooms(List<MyKeyValuePair<string>> TF_Rooms)
        {
            rooms = TF_Rooms;
        }
        public MyKeyValuePair<string> setRoom(string roomName)
        {
            for(int i = 0;i<= rooms.Count - 1; i++)
            {
                if (roomName.ToLower().Equals(rooms[i].GetKey().ToLower()))
                {
                    currentRoomIndex = i;
                    return rooms[currentRoomIndex];
                }
            }
            return rooms[currentRoomIndex];
        }
        public bool checkRoom(string roomName)
        {

            for (int i = 0; i <= rooms.Count - 1; i++)
            {
                if (roomName.ToLower().Equals(rooms[i].GetKey().ToLower()))
                {
                    return true;
                }
            }
            return false;

        }
        
    }
}
