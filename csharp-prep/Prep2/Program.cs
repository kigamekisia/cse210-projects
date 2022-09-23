using System;

namespace Prep2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 2");
            Console.Write("What is your grade percentage? ");
            string userGrade = Console.ReadLine();
            int number = int.Parse(userGrade);
            string letter ="";
            if (number >= 90)
            {
                letter ="A";
            }
            else if (number >= 80)
            {
                letter ="B";
            }
            else if (number >= 70)
            {
                letter ="C";
            }
            else if (number >= 60)
            {
                letter ="D";
            }
            else
            {
                letter ="F";
            }
            Console.WriteLine($"Your garde is {letter}");
            if (number >= 70)
            {
                Console.WriteLine("Congratulations you passed the class");
            }
            else
            {
                Console.WriteLine("You failed the class, Work harder next time");
            }
        }
    }
}
