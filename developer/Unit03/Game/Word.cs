using System;
using System.Collections.Generic;

namespace Unit03.Game
{
    
    public class Word
    {

        List<string> _word;

        //create a list of words
        public Word()
        {
            _word = new List<string>{"encapsulation", "mormon", "alma", "game", 
                                    "temple", "jumper", "random", "moses"};

        }

        //randomly chooses a word
        public string GetRandomWord()
                {
                    Random randomWord = new Random();
                    int index = randomWord.Next(_word.Count);
                    var displayWord = _word[index];
                
                    return displayWord;
                }
    }
}