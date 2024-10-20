using System;

namespace MoshFund_LoopExercises
{
    public class ProcessInputNumber
    {
        //2- Write a program and continuously ask the user to enter a number or "ok" to exit.
        //Calculate the sum of all the previously entered numbers and display it on the console.

        public static int InputNumber()
        {
            int count = 0;
            var exit = "ok";
            while (true)
            {
                Console.WriteLine("Enter a number or \'ok\' to exit");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Enter a valid number or OK to exit");
                }
                else if (input.Equals(exit, StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else
                {
                    if (int.TryParse(input, out int number))
                    {
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number");
                    }
                }
            }

            Console.WriteLine("No of Entries: " + count);

            return count;
        }

    }
}

