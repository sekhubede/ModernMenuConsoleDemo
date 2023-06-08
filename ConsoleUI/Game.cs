using MenuLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Game
    {
        public void Start()
        {
            Console.Title = "Paint Drying - The Game!";

            RunMainMenu();

        }

        private void RunMainMenu()
        {
            string prompt = @"

███╗   ███╗ ██████╗ ██████╗ ███████╗██████╗ ███╗   ██╗    ███╗   ███╗███████╗███╗   ██╗██╗   ██╗
████╗ ████║██╔═══██╗██╔══██╗██╔════╝██╔══██╗████╗  ██║    ████╗ ████║██╔════╝████╗  ██║██║   ██║
██╔████╔██║██║   ██║██║  ██║█████╗  ██████╔╝██╔██╗ ██║    ██╔████╔██║█████╗  ██╔██╗ ██║██║   ██║
██║╚██╔╝██║██║   ██║██║  ██║██╔══╝  ██╔══██╗██║╚██╗██║    ██║╚██╔╝██║██╔══╝  ██║╚██╗██║██║   ██║
██║ ╚═╝ ██║╚██████╔╝██████╔╝███████╗██║  ██║██║ ╚████║    ██║ ╚═╝ ██║███████╗██║ ╚████║╚██████╔╝
╚═╝     ╚═╝ ╚═════╝ ╚═════╝ ╚══════╝╚═╝  ╚═╝╚═╝  ╚═══╝    ╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ 
                                                                                                
Welcome to the Paint Drying Simulator. What would you like to do?
(Use the arrow keys to cycle through options and press enter to select an option.)";

            string[] options = { "Play", "About", "Exit" };

            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunFirstChoice();
                    break;
                case 1:
                    DisplayAboutInfo();
                    break;
                case 2:
                    ExitGame();
                    break;
            }

        }

        private void ExitGame()
        {
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(true);
            Environment.Exit(0);
        }

        private void DisplayAboutInfo()
        {
            Console.Clear();
            Console.WriteLine("This game demo was created by Mike Hadley.");
            Console.WriteLine("It uses assets from http://patorjk.come/software/taag.");
            Console.WriteLine("This is just a demo... full game coming to concole near you soon!");
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey(true);
            RunMainMenu();
        }

        private void RunFirstChoice()
        {
            string prompt = "What color paint would you like to watch dry?";
            string[] options = { "Red", "Green", "Blue", "Yellow" };
            Menu colorMenu = new Menu(prompt, options);
            int selectedIndex = colorMenu.Run();

            ExitGame();
        }

        private void WaitForKey()
        {
            Console.WriteLine("\nPress any key...");
            Console.ReadKey(true);
        }

    }
}
