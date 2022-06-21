using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureDataDriven
{
    class Adventure
    {
      
        public static void Main(string[] args)
        {
            
            GameLogic GL = GameLogic.getInstance();
            Controller input = Controller.getInstance();
            View screen = View.getInstance();
            bool ended = false;
            GL.initializeRooms();


            screen.GetRoomDetails(GL.firstRoom);
            screen.printLocation();
            screen.printToScreen();

            screen.printLoop();

            var inputVar = input.GetCommand();
            if (inputVar == "quit" || inputVar == "q")
            {
                ended = true; 
            }
            else
                GL.DoCommand(inputVar);

            while (!ended)
            {
                screen.GetRoomDetails(GL.currentRoom);
                screen.printLocation();
                screen.printLoop();
                inputVar = input.GetCommand();
                if (inputVar == "quit" || inputVar == "q")
                   ended = true;
                else
                   GL.DoCommand(inputVar);
            }
            screen.printQuit();
            var quitVar = Console.ReadLine();
            System.Environment.Exit(0);


        }
        
    }
}
