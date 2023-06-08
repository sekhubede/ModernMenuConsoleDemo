using MenuLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Game
    {
        public void Start()
        {
            string prompt = "Welcome to the Paint Drying Simulator. What would you like to do?";
            string[] options = { "Play", "About", "Exit" };

            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            WaitForKey();
        }



        public void WaitForKey()
        {
            Console.WriteLine("\nPress any key...");
            Console.ReadKey(true);
        }

    }
}
