using System;


namespace Unit02.Game
{   
    
    // TODO: Implement the Card class as follows...
    // 1) Add the class declaration. Use the following class comment.

        /// <summary>
        /// A Card with values between 1-13.
        /// 
        /// The responsibility of Card is to keep track of its currently drawn value 
        /// 
        /// </summary> 
    public class Card
    {
        public int _value = 0;
    // 2) Create the class constructor. Use the following method comment.

        /// <summary>
        /// Constructs a new instance of Card.
        /// </summary>
        public Card()
        {

        }
    
    // 3) Create the Draw() method. Use the following method comment.
        
        /// <summary>
        /// Generates a new random value. 
        /// </summary>
        public void Draw()
        {
            Random random = new Random();
            _value = random.Next(1, 14);
        }
    }    
}