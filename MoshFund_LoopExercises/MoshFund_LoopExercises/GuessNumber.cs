using System;

namespace MoshFund_LoopExercises
{

    public partial class Program
    {
        public class GuessNumber
        {
            //4- Write a program that picks a random number between 1 and 10.
            //Give the user 4 chances to guess the number. If the user guesses the number,
            //display “You won"; otherwise, display “You lost".
            public static int GetValidNumber()
            {
                int number;
                while (true)
                {
                    Console.WriteLine("Enter a number between 1 and 10");
                    if (int.TryParse(Console.ReadLine(), out number) && number >= 1 && number <= 10)
                    {
                        return number;
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid number between 1 and 10");
                    }
                }
               
            }
            public static void GuessedNumber()
            {
                
                int attempts = 4;
                var number = new Random().Next(1, 10);
                for (int i = 1; i <= attempts; i++)
                {
                    var guess = GetValidNumber();

                    if (guess == number)
                    {
                        Console.WriteLine("You Won");
                        return;
                    }
                    else if (i < attempts)
                    {
                        Console.WriteLine("Try Again");
                    }
                    
                }
                Console.WriteLine("You lose! Better luck next time");

            }
        }
    }
}
