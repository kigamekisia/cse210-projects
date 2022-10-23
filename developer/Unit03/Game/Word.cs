using System;
using System.Collections.Generic;

namespace Unit03.Game
{
    
    public class Word
    {

        List<string> _word;

        //create array of words to guess
        public Word()
        {
            _word = new List<string>{"encapsulation", "program", "class", "game", 
                                    "code", "jumper", "random", "terminal"};

        }

        //randomly chooses a word
        public string GetRandomWord()
                {
                    Random _randWord = new Random();
                    int index = _randWord.Next(_word.Count);
                    var _displayWord = _word[index];
                
                    return _displayWord;
                }
    }
}