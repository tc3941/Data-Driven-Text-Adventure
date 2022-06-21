using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextAdventureDataDriven
{
    class GameLogic
    {
        
        List<string> entrees = new List<string>{ "Name", "Location", "Details", "NorthRoom", "EastRoom", "SouthRoom", "WestRoom" };

        Rooms rooms = Rooms.getInstance();
        public List<MyKeyValuePair<string>> textFileEntrees = new List<MyKeyValuePair<string>>();

        public static GameLogic singleTon = new GameLogic();

        public static GameLogic getInstance()
        {
            return singleTon;
        }

        public MyKeyValuePair<string> firstRoom
        {
            get
            {
                return setRoom("SunDial");
            }
        }
        public MyKeyValuePair<string> currentRoom
        {
            get
            {
                return rooms.currentRoom;
            }
        }
        public MyKeyValuePair<string> setRoom(string roomName)
        {
            return rooms.setRoom(roomName);
        }
        public void DoCommand(string command)
        {
            MyKeyValuePair<string> newRoom = null,oldRoom = rooms.currentRoom;
            Console.WriteLine();
            string transition = "";
            switch (command)
            {
                case "north":
                    if (rooms.checkRoom(rooms.North))
                    {
                        transition = rooms.NorthTransition;
                        newRoom = rooms.setRoom(rooms.North);
                        Console.WriteLine(transition + "\nYou've arrived at " + rooms.RoomName);
                    }
                    else
                    {
                        rooms.setRoom(oldRoom.GetKey());
                        Console.WriteLine("There is nothing " + command + ". You return to " + rooms.RoomName);
                    }
                    break;
                case "east":
                    if (rooms.checkRoom(rooms.East))
                    {
                        transition = rooms.EastTransition;
                        newRoom = rooms.setRoom(rooms.East);
                        Console.WriteLine(transition + "\nYou've arrived at " + rooms.RoomName);
                    }
                    else
                    {
                        rooms.setRoom(oldRoom.GetKey());
                        Console.WriteLine("There is nothing " + command + ". You return to " + rooms.RoomName);
                    }
                    break;
                case "south":
                    if (rooms.checkRoom(rooms.North))
                    {
                        transition = rooms.NorthTransition;
                        newRoom = rooms.setRoom(rooms.North);
                        Console.WriteLine(transition + "\nYou've arrived at " + rooms.RoomName);
                    }
                    else
                    {
                        rooms.setRoom(oldRoom.GetKey());
                        Console.WriteLine("There is nothing " + command + ". You return to " + rooms.RoomName);
                    }
                    break;
                case "west":
                    if (rooms.checkRoom(rooms.West))
                    {
                        transition = rooms.WestTransition;
                        newRoom = rooms.setRoom(rooms.West);
                        Console.WriteLine(transition + "\nYou've arrived at " + rooms.RoomName);
                    }
                    else
                    {
                        rooms.setRoom(oldRoom.GetKey());
                        Console.WriteLine("There is nothing " + command + ". You return to " + rooms.RoomName);
                    }
                    break;
                case "look": Console.WriteLine(rooms.Details); break;
                default: break;
            }        
        }

        public List<MyKeyValuePair<string>> initializeRooms()
        {
            string textFile = "";
            try
            {
                textFile = File.ReadAllText("TextDoc.txt");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("NO FILE!");
            }
            


            if (textFile.IndexOf("[") >= 0)//Checks if text file is formatted the way I intended
            {
                textFile = textFile.Replace('\t', ' ');//Removes tabs to make the following code more simple
                while (textFile.IndexOf("[") >= 0)//While the text files has rooms
                {
                   
                    textFileEntrees.Add(new MyKeyValuePair<string>());//Create new room Key Value
                    var index1 = textFile.IndexOf("[");
                    var index2 = textFile.IndexOf("]", index1 + 1);
                    Console.WriteLine(textFile.Substring(index1, index2 - index1 + 1));//prints the room name
                    
                    textFile = textFile.Remove(index1, index2-index1+1);//removes the room name/title

                    for (int i = 0; i <= entrees.Count - 1; i++)
                    {
                        textFile = textFile.Remove(0, textFile.IndexOf(entrees[i]) + entrees[i].Length);//removes the catagoric name
                        if (i < entrees.Count - 1)
                        {
                            //Console.WriteLine(/*textFile.IndexOf("Name") +*/ entrees[i] + " : " + textFile.Substring(0, textFile.IndexOf(entrees[i + 1])));

                            if (i == 0)
                                textFileEntrees[textFileEntrees.Count - 1].SetKey(textFile.Substring(0, textFile.IndexOf(entrees[i + 1])));
                            else
                                textFileEntrees[textFileEntrees.Count - 1].SetVal(i - 1, textFile.Substring(0, textFile.IndexOf(entrees[i + 1])));
                        }
                        else
                        {
                            if (i == entrees.Count - 1)
                                textFileEntrees[textFileEntrees.Count - 1].SetVal(5,textFile.Substring(0, textFile.IndexOf("+")));
                        }

                    }

                }
            }
            
            /*Debug for info
            foreach(MyKeyValuePair<string> kvp in textFileEntrees)
            {
                Console.WriteLine(kvp.GetKey());
                Console.WriteLine("Location " + kvp.GetValue1());
                Console.WriteLine("Details " + kvp.GetValue2());
                Console.WriteLine("North Room " + kvp.GetValue3());
                Console.WriteLine("East Room " + kvp.GetValue4());
                Console.WriteLine("South Room " + kvp.GetValue5());
                Console.WriteLine("West Room " + kvp.GetValue6());

            }*/
           
            foreach (MyKeyValuePair<string> kvp in textFileEntrees)//remove textFile errors
            {
                kvp.SetKey(kvp.GetKey().Substring(1));
                kvp.SetKey(kvp.GetKey().Replace("\n", string.Empty));
                kvp.SetKey(kvp.GetKey().Replace("\r", string.Empty));
                kvp.SetKey(kvp.GetKey().Replace('-', '\n'));

                kvp.SetValue1(kvp.GetValue1().Substring(1));
                kvp.SetValue1(kvp.GetValue1().Replace("\n", string.Empty));
                kvp.SetValue1(kvp.GetValue1().Replace("\r", string.Empty));
                kvp.SetValue1(kvp.GetValue1().Replace('-', '\n'));

                kvp.SetValue2(kvp.GetValue2().Substring(1));
                kvp.SetValue2(kvp.GetValue2().Replace("\n", string.Empty));
                kvp.SetValue2(kvp.GetValue2().Replace("\r", string.Empty));
                kvp.SetValue2(kvp.GetValue2().Replace('-', '\n'));

                kvp.SetValue3(kvp.GetValue3().Substring(1));
                kvp.SetValue3(kvp.GetValue3().Replace("\n", string.Empty));
                kvp.SetValue3(kvp.GetValue3().Replace("\r", string.Empty));
                kvp.SetValue3(kvp.GetValue3().Replace('-', '\n'));


                kvp.SetValue4(kvp.GetValue4().Substring(1));
                kvp.SetValue4(kvp.GetValue4().Replace("\n", string.Empty));
                kvp.SetValue4(kvp.GetValue4().Replace("\r", string.Empty));
                kvp.SetValue4(kvp.GetValue4().Replace('-', '\n'));


                kvp.SetValue5(kvp.GetValue5().Substring(1));
                kvp.SetValue5(kvp.GetValue5().Replace("\n", string.Empty));
                kvp.SetValue5(kvp.GetValue5().Replace("\r", string.Empty));
                kvp.SetValue5(kvp.GetValue5().Replace('-', '\n'));


                kvp.SetValue6(kvp.GetValue6().Substring(1));
                kvp.SetValue6(kvp.GetValue6().Replace("\n", string.Empty));
                kvp.SetValue6(kvp.GetValue6().Replace("\r", string.Empty));
                kvp.SetValue6(kvp.GetValue6().Replace('-', '\n'));

            }
            //Debug for info
            /*
            foreach (MyKeyValuePair<string> kvp in textFileEntrees)
            {
                Console.WriteLine(kvp.GetKey());
                Console.WriteLine("Location " + kvp.GetValue1());
                Console.WriteLine();
                Console.WriteLine("Details " + kvp.GetValue2());
                Console.WriteLine();
                Console.WriteLine("North Room " + kvp.GetValue3());
                Console.WriteLine();
                Console.WriteLine("East Room " + kvp.GetValue4());
                Console.WriteLine();
                Console.WriteLine("South Room " + kvp.GetValue5());
                Console.WriteLine();
                Console.WriteLine("West Room " + kvp.GetValue6());
                Console.WriteLine();

            }*/         
            rooms.setRooms(textFileEntrees);
            return textFileEntrees;
        }
    }
}
