using System;

namespace MoshFund_Iterations
{
    public static class ForEachLoop
    {
        public static void PrintCharacters()
        {
            var name = "Abdullahi Yusuf";
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i]);
            }
            Console.WriteLine();

            foreach (var character in name)
            {
                Console.Write(character);
            }
        }

        public static void PrintNumbers()
        {
            var numbers = new int[5] { 3, 4, 5, 6, 7, };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

    }
}
