using System;

namespace MoshFund_Iterations
{
    public class WhileLoops
    {
        public static void PrintEvenNUmbers()
        {
            var number = 0;
            while (number <= 10)
            {
                if (number % 2 == 0)
                    Console.WriteLine(number);
                    
                number++;
            }
        }
        public static void EchoName()
        {
            while (true)
            {
                Console.Write("Enter a name: ");
                var input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                break;

            }
        }
    }
}
