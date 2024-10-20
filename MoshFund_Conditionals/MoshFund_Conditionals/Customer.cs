using System;

namespace MoshFund_Conditionals
{
    public class Customer
    {
        public static bool isGoldCustomer;
        public static float price;
        public static void IsNotGoldCustomer()
        {
            isGoldCustomer = false;
            if (isGoldCustomer)
            {
                price = 19.95f;
            }
            else
            {
                price = 29.95f;
            }

            Console.WriteLine("Price: " + price);
        }

        public static void GoldCustomer()
        {
            isGoldCustomer = true;
            price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine("GoldCustomer Price: " + price);
        }
    }
}
