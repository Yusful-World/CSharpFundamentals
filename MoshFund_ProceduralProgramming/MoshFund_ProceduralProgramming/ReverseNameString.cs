using System;

namespace MoshFund_ProceduralProgramming
{
    public class ReverseNameString
    {
        public static void GetReversedName()
        {
            Console.WriteLine("What is your name");
            var name = Console.ReadLine();
            var reverse = ReverseName(name);
            Console.WriteLine(reverse);
        }

        static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            return new string(array);
        }
    }


}
