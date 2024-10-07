using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshFund_Enums
{
    public enum ShippingMethods
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3,
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethods.Express;
            Console.WriteLine((int)method);     //enums are internally integers unless stated otherwise upon declaration

            var methodId = 3;
            Console.WriteLine((ShippingMethods)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethods)Enum.Parse(typeof(ShippingMethods), methodName);
            Console.WriteLine(shippingMethod);
        }
    }
}
