using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureDataDriven
{
    abstract class Room
    {
        public string description, where, name;
        List<Room> connectedRooms = new List<Room>();
        Room NorthRoom, SouthRoom, EastRoom, WestRoom;

        public string RoomName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Room rooms
        {

           set
            {
                connectedRooms.Add(value);
            }
        }
        public Room North
        {
            get
            {
                return NorthRoom;
            }
            set
            {
                NorthRoom = value;
            }
        }
        public Room South
        {
            get
            {
                return SouthRoom;
            }
            set
            {
                SouthRoom = value;
            }
        }
             public Room East
        {
            get
            {
                return EastRoom;
            }
            set
            {
                EastRoom = value;
            }
        }

         public Room West
        {
            get
            {
                return WestRoom;
            }
            set
            {
                WestRoom = value;
            }
        }
    
        public string Details
        {
            set
            {
                description = value;
            }
            get
            {
                return description;
            }
        }
        public string Location
        {
            set
            {
                where = value;
            }
            get
            {
                return where;
            }
        }

        public Room(string desc,string where)
        {
            this.description = desc;
            this.where = where;
        }
        public Room()
        {
        }
        public Room GetRoom(int i)
        {
            return connectedRooms[i];
        }

    }
}
