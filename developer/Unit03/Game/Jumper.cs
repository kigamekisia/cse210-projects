using System;
using System.Collections.Generic;

namespace Unit03.Game
{
    public class Jumper
    {

        int parachuteUpdates;

        //store
        public Jumper()
        {
            parachuteUpdates = 4;
        }

        public bool CheckUpdate()
        {
            if (parachuteUpdates == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        ///updates wrong guess 
        public void theUpdates()
        {
            parachuteUpdates -= 1;
        }

        ///For display in the director class
        public int GetParachuteUpdates()
        {
            return parachuteUpdates;
        }

        ///Prints parachute board

        public void PrintJumper()
        {
            PrintParachute();
            bool proc = CheckUpdate();
            if (proc)
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
            int updtes = GetParachuteUpdates();
            if (updtes == 4)
            {
                Console.WriteLine("  ___");
                Console.WriteLine(" /   \\");
                Console.WriteLine(" \\   /");
                Console.WriteLine("  \\ /");
            }
            else if (updtes == 3)
            {
                Console.WriteLine(" /   \\");
                Console.WriteLine(" \\   /");
                Console.WriteLine("  \\ /");
            }
            else if (updtes == 2)
            {
                Console.WriteLine(" \\   /");
                Console.WriteLine("  \\ /");
            }
            else if (updtes == 1)
            {
                Console.WriteLine("  \\ /");
            }
        }
        
    }
}