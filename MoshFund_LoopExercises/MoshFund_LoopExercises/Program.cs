using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MoshFund_LoopExercises
{
    public class GetMaximumNumber
    {
        //5- Write a program and ask the user to enter a series of numbers separated by comma.
        //Find the maximum of the numbers and display it on the console. For example,
        //if the user enters “5, 3, 8, 1, 4", the program should display 8.
        public static string GetInput()
        {
            Console.WriteLine("Enter a series of numbers seperated by a comma; e.g. 1, 2, 3...");
            return Console.ReadLine();
        }

        public static string[] GetInputCharacter()
        {
            return GetInput().Split(',');
            
        }

        public static int[] GetInputArray(string[] inputArray)
        {
            List<int> numbers = new List<int>();

            // Attempt to parse each element in the array
            foreach (var str in inputArray)
            {
                if (int.TryParse(str.Trim(), out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine($"Invalid number: {str}. Skipping...");
                }
            }

            return numbers.ToArray();
        }

        public static int FindMaxNumber(int[] numbers)
        {
            return numbers.Max();
        }

        public static void MaxNumber()
        {
            var inputCharacters = GetInputCharacter();
            var inputArray = GetInputArray(inputCharacters);

            if (inputArray.Length > 0)
            {
                int maxNumber = FindMaxNumber(inputArray);
                Console.WriteLine("Max number is " + maxNumber);
            }
            else
            {
                Console.WriteLine("No valid numbers were entered.");
            }

        }

    }

    public partial class Program
    {

        static void Main(string[] args)
        {
            GetMaximumNumber.MaxNumber();
            
            //GuessNumber.GuessedNumber();

            //FactorialExercise.NumberFactorial();
            
            //ProcessInputNumberRefactored.ProcessInput();
            //var numbers = new PrintNumbers();
            //var numbersDivisibleBy3 = numbers.PrintNumbersDivisibleBy3();
            //Console.WriteLine(numbersDivisibleBy3);
            //var countNumbersDivisibleBy3 = numbers.CountNumbers();
            //Console.WriteLine("Sum of Numbers Divisible by 3: " + countNumbersDivisibleBy3);

        }
    }
}
