using System;
using System.Collections.Generic;

namespace Unit03.Game
{
    public class Jumper
    {

        int parachuteLives;

        ///stores lives
        public Jumper()
        {
            parachuteLives = 4;
        }

        public bool CheckAlive()
        {
            if (parachuteLives == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        ///updates lives for each time the user does not guess correctly
        public void UpdateLives()
        {
            parachuteLives -= 1;
        }

        ///Takes the variable parachutelives to display it in the director class
        public int GetParachuteLives()
        {
            return parachuteLives;
        }

        ///Prints parachute board

        public void PrintJumper()
        {
            PrintParachute();
            bool isAlive = CheckAlive();
            if (isAlive)
            {
                Console.WriteLine("   o");
            }
            else 
            {
                Console.WriteLine("   x");
            }
            Console.WriteLine("  /|\\");
            Console.WriteLine("  / \\\n");
            Console.WriteLine("^^^^^^^\n");
        }

        public void PrintParachute()
        {
            int lives = GetParachuteLives();
            if (lives == 4)
            {
                Console.WriteLine("  ___");
                Console.WriteLine(" /   \\");
                Console.WriteLine(" \\   /");
                Console.WriteLine("  \\ /");
            }
            else if (lives == 3)
            {
                Console.WriteLine(" /   \\");
                Console.WriteLine(" \\   /");
                Console.WriteLine("  \\ /");
            }
            else if (lives == 2)
            {
                Console.WriteLine(" \\   /");
                Console.WriteLine("  \\ /");
            }
            else if (lives == 1)
            {
                Console.WriteLine("  \\ /");
            }
        }
        
    }
}