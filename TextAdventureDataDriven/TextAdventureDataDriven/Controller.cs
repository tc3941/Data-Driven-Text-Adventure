using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureDataDriven
{
    class Controller
    {
        public static Controller singleTon = new Controller();

        public static Controller getInstance()
        {
            return singleTon;
        }

        string command;

        public string Command
        {
            get
            {
                return command;
            }
            set
            {
                command = value;
            }
        }
        public string GetCommand()
        {
           
            var choiceChosen = false;
            while (!choiceChosen)
            {
                command = Console.ReadLine();
                command = command.ToLower();
                switch (command)
                {
                    case "north": choiceChosen = true; Console.WriteLine("You head North."); break;
                    case "east": choiceChosen = true; Console.WriteLine("You head East."); break;
                    case "south": choiceChosen = true; Console.WriteLine("You head South."); break;
                    case "west": choiceChosen = true; Console.WriteLine("You head West."); break;
                    case "look": choiceChosen = true; Console.WriteLine("You look around."); break;
                    case "quit": choiceChosen = true; Console.WriteLine("You quit."); break;
                    case "q": choiceChosen = true; Console.WriteLine("You quit."); break;
                    default: Console.WriteLine("Invalid Input. Why dont you do a command?"); break;
                }
            }
            //command = Console.ReadLine();
            return command;
        }
    }
}
