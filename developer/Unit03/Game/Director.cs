using System;
using System.Collections.Generic;

namespace Unit03.Game
{

    /// <summary>
    /// The responsibility of a Director will be control the sequence of play.
    /// </summary>

    public class Director
    {
        Word word = new Word();
        TerminalService terminal = new TerminalService();
        Jumper jumper = new Jumper();
        private bool _isPlaying;
        private string _secretWord;
        private string _userGuesses;
        private string _currentGuess;
        private string _printableWord;


        public Director()
        {
            _isPlaying = true;
            _secretWord = word.GetRandomWord();
            _userGuesses = "";
            
            for (int i = 0; i < _secretWord.Length; i++)
            {
                _userGuesses += "_";
            }
            _printableWord = _userGuesses;
        }

        //Starts the game by running the main game loop and print the jumper board.
        public void StartGame()
        {
            PrintUserGuesses();
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
            _currentGuess = terminal.GetInput("Guess a letter [a-z]: ");
        }


        // Updates the users guesses.
        private void DoUpdates()
        {
            
            if (_secretWord.Contains(_currentGuess))
            {
                _printableWord = "";
                for (int i = 0; i < _secretWord.Length; i++)
                {
                    if(_secretWord[i] == _currentGuess[0])
                    {
                        _printableWord += _currentGuess;
                    }
                    else
                    {
                        _printableWord += _userGuesses[i];
                    }
                }
                _userGuesses  = _printableWord;
            }
            else 
            {
                jumper.UpdateLives();
            }
        }

        // Displays the jumper and tracks the user's guess.

        private void DoOutputs()
        {
            PrintUserGuesses();
            jumper.PrintJumper();
            _isPlaying = jumper.CheckAlive();
            if (_printableWord == _secretWord)
            {
                _isPlaying = false;
            }
        }

        private void PrintUserGuesses()
        {
            Console.WriteLine("\n");
            for (int i = 0; i < _printableWord.Length; i++)
            {
                Console.Write($"{_printableWord[i]} ");
            }
            Console.WriteLine("\n");
        }

        
    }

}