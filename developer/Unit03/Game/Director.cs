using System;
using System.Collections.Generic;

namespace Unit03.Game
{

    /// <summary>
    /// The responsibility of the Director is to control the sequence of the game.
    /// </summary>

    public class Director
    {
        Word word = new Word();
        TerminalService terminal = new TerminalService();
        Jumper jumper = new Jumper();
        private bool _isPlaying;
        private string secretWord;
        private string userGuess;
        private string currentGuess;
        private string theWord;


        public Director()
        {
            _isPlaying = true;
            secretWord = word.GetRandomWord();
            userGuess = "";
            
            for (int i = 0; i < secretWord.Length; i++)
            {
                userGuess += "_";
            }
            theWord = userGuess;
        }

        //Starts the game by running the main game loop.
        public void StartGame()
        {
            displayUserGuess();
            jumper.PrintJumper();

            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
            
        }

        // Asks the user to guess a letter.
        private void GetInputs()
        {
            currentGuess = terminal.GetInput("Guess a letter [a-z]: ");
        }


        // Updates the users guess.
        private void DoUpdates()
        {
            
            if (secretWord.Contains(currentGuess))
            {
                theWord = "";
                for (int i = 0; i < secretWord.Length; i++)
                {
                    if(secretWord[i] == currentGuess[0])
                    {
                        theWord += currentGuess;
                    }
                    else
                    {
                        theWord += userGuess[i];
                    }
                }
                userGuess  = theWord;
            }
            else 
            {
                jumper.theUpdates();
            }
        }

        // Displays the jumper and tracks the user's guess.

        private void DoOutputs()
        {
            displayUserGuess();
            jumper.PrintJumper();
            _isPlaying = jumper.CheckUpdate();
            if (theWord == secretWord)
            {
                _isPlaying = false;
            }
        }

        private void displayUserGuess()
        {
            Console.WriteLine("\n");
            for (int i = 0; i < theWord.Length; i++)
            {
                Console.Write($"{theWord[i]} ");
            }
            Console.WriteLine("\n");
        }

        
    }

}