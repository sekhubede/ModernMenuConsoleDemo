using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuLibrary
{
    public class Menu
    {
        // Adding fields for the menu
        private int SelectetIndex;
        private string[] Options;
        private string Prompt;

        // Adding a constructor with two parameters
        public Menu(string prompt, string[] options)
        {
            this.Prompt = prompt;
            this.Options = options;
            this.SelectetIndex = 0;
        }

       
    }
}
