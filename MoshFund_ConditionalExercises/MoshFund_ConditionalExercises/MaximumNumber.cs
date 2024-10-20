using System;

namespace MoshFund_ConditionalExercises
{
    public class MaximumNumber
    {
        //2- Write a program which takes two numbers from the console and displays the maximum of the two.
        public int input1;
        public int input2;
        public void InputNumber()
        {
            Console.WriteLine("Enter a valid number: ");
            input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another valid number: ");
            input2 = int.Parse(Console.ReadLine());
        }

        public int MaxNumber()
        {
           var maxNumber = (input1 >  input2) ? input1 : input2;
            return maxNumber;
        }

        public void OutputNumber()
        {
            var outputNumber = MaxNumber();
            Console.WriteLine(outputNumber);
        }
    }
}
