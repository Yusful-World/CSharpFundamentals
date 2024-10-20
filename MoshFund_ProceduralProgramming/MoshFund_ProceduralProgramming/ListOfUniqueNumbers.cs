using System;
using System.Collections.Generic;

namespace MoshFund_ProceduralProgramming
{
    public class ListOfUniqueNumbers
    {
        public static void PrintUniqueNumber()
        {
            var numbers = ValidateInput(InputNumber());
            Console.WriteLine("Unique Numbers: ");
            foreach (var number in GetUniqueNumbers(numbers))
                Console.WriteLine(number);
        }
        public static string InputNumber()
        {
            Console.WriteLine("Enter a number (or Quit to Exit)");
            var input = Console.ReadLine();
            return input;
        }
        public static List<int> ValidateInput(string input)
        {
            var numbers = new List<int>();

            while (true)
            {
                

                if (string.Equals(input, "quit", StringComparison.OrdinalIgnoreCase))
                    break;

                if (int.TryParse(input, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                // OR
                // numbers.Add(Convert.ToInt32(input));
            }

            return numbers;
        }

        public static List<int> GetUniqueNumbers(List<int> numbers)
        {
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            
            return uniques;
        }

        
    }


}
