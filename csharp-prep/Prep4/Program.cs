using System;
using System.Collections.Generic;

namespace Prep4
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> numbers = new List<int>();
            int userNumber=-1;
            while(userNumber!=0)
            {
                Console.Write("Enter a list of numbers (type 0 when finished): ");
                string userResponse = Console.ReadLine();
                userNumber = int.Parse(userResponse);
                numbers.Add(userNumber);
            }
            // part 1: compute the sum
            int sum = 0;
            foreach (int number in numbers)
            {
                sum+=number;
            }
            Console.WriteLine($"The sum is {sum}");
            // Part 2 compute the average
            float average = sum / numbers.Count;
            Console.WriteLine($"The average is {average}");
            // Part 3 find the max
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number>max)
                {
                    {
                        // if this number is greater that the max then we have found the new max
                        max= number;
                    }
                }
            }
            Console.WriteLine($"The Max is: {max}");
        }
    }
}
