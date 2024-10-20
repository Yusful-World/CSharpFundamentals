using System;

namespace MoshFund_Conditionals
{
    public class Seasons
    {
        public static void IsSeason()
        {
            Season season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:     //note that a : is used and not ; 
                    Console.WriteLine("It's autumn and a beautiful season");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's a perfect to visit the beach");
                    break;
                case Season.Spring:
                    Console.WriteLine("spring is here again!");
                    break ;
                default:
                    Console.WriteLine("Let's go to winter fell");
                    break;
            }



        }

    }
    public enum Season
    {
        Autumn,
        Summer,
        Spring,
        Winter
    }
}
