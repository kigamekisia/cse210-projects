using System;
using System.Collections.Generic;


namespace Unit02.Game
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        List<Card> cards = new List<Card>();
        bool _isPlaying = true;
        int _win = 100;
        int _loss = -75;
        int _totalScore = 300;
        int currentCard;
        int nextCard;

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
           
            Card card = new Card();
            cards.Add(card);
           
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            Card card = new Card();
            card.Draw();
            currentCard = card._value;
            string guess;
            while (_isPlaying)
            {
                guess = GetInputs();
                DoUpdates(guess);
                DoOutputs();
                currentCard = nextCard;
            }
        }

        /// <summary>
        /// Gets input from the user.
        /// </summary>
        public string GetInputs()
        {
            Console.Write("Do you want to draw a card? [y/n] ");
            string DrawCard = Console.ReadLine();
            if (_isPlaying = (DrawCard == "y"))
            {
            //Display Card
            Console.WriteLine($"The card is {currentCard}");
            //Get guess from user
            Console.Write("Guess if the next card be Lower or higher? [l/h] ");
            string guess = Console.ReadLine();

            return guess;
            }
            else
            {
                return "over";
            }

        }

        /// <summary>
        /// Updates the player's score.
        /// </summary>
        public void DoUpdates( string guess)
        {
            int _score = 0;
            Card card = new Card();

            if (!_isPlaying)
            {
                return;
            }
            card.Draw();
            nextCard = card._value;
            if (guess == "h")
            {
                if (currentCard < nextCard)
                {
                    _score = _win;
                    Console.WriteLine("You guessed right!");
                }    
                else
                {
                    _score = _loss;
                    Console.WriteLine("You lost! ");
                }
            }
            if (guess == "l")
            {
                if (currentCard < nextCard)
                {
                    _score = _loss;
                    Console.WriteLine("You lose! ");
                }
                else
                {
                    _score = _win;
                    Console.WriteLine("You guessed correctly!");
                }    
            }

            _totalScore += _score;
        }

        /// <summary>
        /// Displays the card and score. 
        /// </summary>
        public void DoOutputs()
        {
            if (!_isPlaying)
            {
                return;
            }

            Console.WriteLine($"The next card is: {nextCard}");
            Console.WriteLine($"Your score is: {_totalScore}\n");
            _isPlaying = (_totalScore > 0);
        }
        
    }
}


