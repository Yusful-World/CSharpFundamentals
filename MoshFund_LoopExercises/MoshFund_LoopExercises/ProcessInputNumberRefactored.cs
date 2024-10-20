using System;

namespace MoshFund_LoopExercises
{
    public class ProcessInputNumberRefactored 
    {
        //2- Write a program and continuously ask the user to enter a number or "ok" to exit.
        //Calculate the sum of all the previously entered numbers and display it on the console.

        public static string GetInput()
        {
            Console.WriteLine("Enter a number or \'ok\' to exit");
            return Console.ReadLine();
        }

        public static bool IsExitCommand(string input)
        {
            return input.Equals("Ok", StringComparison.OrdinalIgnoreCase);
        }

        public static bool IsValidInput(string input, out int number)
        {
            return int.TryParse(input, out number);
        }

        public static int ProcessInput()
        {
            int count = 0;
            while (true)
            {
                var input = GetInput();
                if (IsExitCommand(input))
                {
                    break;
                }
                else
                {
                    if (IsValidInput(input, out int number))
                    {
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number");
                    }
                }
            }
            
            Console.WriteLine("Number of Entries: " + count);

            return count;
        }

    }
}

