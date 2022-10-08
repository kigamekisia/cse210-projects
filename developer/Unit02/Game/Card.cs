using System;


namespace Unit02.Game
{   
    
    // TODO: Implement the Die class as follows...
    // 1) Add the class declaration. Use the following class comment.

        /// <summary>
        /// A small cube with a different number of spots on each of its six sides.
        /// 
        /// The responsibility of Die is to keep track of its currently rolled value and the points its
        /// worth.
        /// </summary> 
    public class Card
    {
        public int _value = 0;
    // 2) Create the class constructor. Use the following method comment.

        /// <summary>
        /// Constructs a new instance of Die.
        /// </summary>
        public Card()
        {

        }
    
    // 3) Create the Roll() method. Use the following method comment.
        
        /// <summary>
        /// Generates a new random value and calculates the points for the die. Fives are 
        /// worth 50 points, ones are worth 100 points, everything else is worth 0 points.
        /// </summary>
        public void Draw()
        {
            Random random = new Random();
            _value = random.Next(1, 14);
        }
    }    
}