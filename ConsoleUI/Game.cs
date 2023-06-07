using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Game
    {
        public void Start()
        {
            Console.WriteLine("The game is starting!");

            ConsoleKeyInfo keyPressed = Console.ReadKey();
            if (ConsoleKey.Enter == keyPressed.Key)
            {
                Console.WriteLine("You pressed ENTER");
            }

            if (ConsoleKey.UpArrow == keyPressed.Key)
            {
                Console.WriteLine("You pressed the UP ARROW");
            }

            WaitForKey();
        }



        public void WaitForKey()
        {
            Console.WriteLine("\npress any key...");
            Console.ReadKey(true);
        }

    }
}
