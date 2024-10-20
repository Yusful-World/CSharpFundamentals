using System;

namespace MoshFund_Conditionals
{
    public class DayTime   //if and switch/case
    {
        public static int hour;
        public static void DayTimeFormat()
        {
            hour = 10;
            if (hour > 0 && hour < 12)
                Console.WriteLine("It's morning");
            else if (hour >= 12 && hour < 18)
                Console.WriteLine("It's afternoon");
            else
                Console.WriteLine("It's evening");
        }
    }
}
