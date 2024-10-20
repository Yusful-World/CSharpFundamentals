using System;

namespace MoshFund_ConditionalExercises
{
    public class ValidNumber
    //  1- Write a program and ask the user to enter a number.The number should be between 1 to 10.
    //  If the user enters a valid number, display "Valid" on the console.Otherwise, display "Invalid".
    //  (This logic is used a lot in applications where values entered into input boxes need to be validated.)
    {
        public int number;
        public void EnterNumber()
        {
            Console.WriteLine("Enter a number between one and ten");
            number = int.Parse(Console.ReadLine());
        }
        public bool IsValid()
        {
            if (number > 0 && number < 10)
            {
                return true;
            }
            return false;
        }

        public void DisplayNumber()
        {
            if (IsValid())
            {
                Console.WriteLine("Valid");
            }
        }
        
    }
}
