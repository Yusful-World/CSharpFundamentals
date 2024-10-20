using System;
using System.Collections.Generic;

namespace MoshFund_LoopExercises
{
    public class PrintNumbers
    {
        // Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
        // Display the result on the console.

        public int PrintNumbersDivisibleBy3()
        {
            var numbers = GetNumbersDivisibleBy3();
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            return numbers.Count;
        }

        public int CountNumbers()
        {
            int count = 0;
            foreach (var number in GetNumbersDivisibleBy3())
            {
                count++;
            }
            return count;
        }
        public List<int> GetNumbersDivisibleBy3()
        {
            var numbersDivisibleBy3 = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    numbersDivisibleBy3.Add(i);
                }
            }
            return numbersDivisibleBy3;
        }

    }
}
