using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuLibrary
{
    public class Menu
    {
        // Fields for the menu
        private int SelectetIndex;
        private string[] Options;
        private string Prompt;

        // A constructor with two parameters to define our menu
        public Menu(string prompt, string[] options)
        {
            this.Prompt = prompt;
            this.Options = options;
            this.SelectetIndex = 0;
        }

        // This method that will be resposible for rendering the menu
       private void DisplayOptions()
        {
            Console.WriteLine(Prompt);

            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;

                if (i == SelectetIndex)
                {
                    prefix = "*";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.WriteLine($"{prefix} << {currentOption} >>");
            }

            Console.ResetColor();
        }

        public int Run()
        {
            ConsoleKey keyPressed;

            do
            {
                Console.Clear();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;
                
                // Update SelectedIndex based on arroe keys.
                if (ConsoleKey.UpArrow == keyPressed)
                {
                    SelectetIndex--;
                    if (-1 == SelectetIndex)
                    {
                        SelectetIndex = Options.Length - 1;
                    }
                }
                else if (ConsoleKey.DownArrow == keyPressed)
                {
                    SelectetIndex++;
                    if (Options.Length == SelectetIndex)
                    {
                        SelectetIndex = 0;
                    }
                }

            } while (ConsoleKey.Enter != keyPressed);

            return SelectetIndex;
        }
    }
}
