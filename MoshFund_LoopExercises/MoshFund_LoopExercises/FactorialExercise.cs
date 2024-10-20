using System;

namespace MoshFund_LoopExercises
{
    public class FactorialExercise
    {
        //3- Write a program and ask the user to enter a number.
        //Compute the factorial of the number and print it on the console. For example, if the user enters 5,
        //the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
        public static string GetInput()
        {
            Console.WriteLine("Enter a number");
            return Console.ReadLine();
        }
        public static bool IsValidInput(string input, out int number)
        {
            return int.TryParse(input, out number);
        }
        public static int NumberFactorial()
        {
            int sum = 1;
            var number = GetInput();
            var digit = IsValidInput(number, out int input);
            for (int i = 1; i <= input; i++)
            {
                sum *= i;
                Console.WriteLine(sum);
            }
            return sum;
        }
    }
}
