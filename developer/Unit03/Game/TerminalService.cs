using System;
using System.Collections.Generic;

namespace Unit03.Game
{
    /// <summary>
    /// The responsibility of a TerminalService is to provide input and output operations for the 
    /// terminal.
    /// </summary>
    public class TerminalService
    {

        /// Constructs a new instance of TerminalService.
        public TerminalService()
        {
        }

        /// Gets text input from the terminal. Directs the user with the given prompt.
        public string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        /// Displays the given text on the terminal. 
        public void WriteText(string text)
        {
            Console.WriteLine(text);
        }
    }
}