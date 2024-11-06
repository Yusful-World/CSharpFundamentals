using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshAdvance_Nullables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NullCoalescence();

            Nullable<DateTime> date = null;

            DateTime? date2 = new DateTime(2014, 4, 17); //alternative of declaring nullable
            DateTime date3 = date2.GetValueOrDefault();
            Console.WriteLine("Date 3: " + date3);

            DateTime? date4 = date3;
            Console.WriteLine("Date4: " + date4);

            Console.WriteLine("GetValue or Default: " + date.GetValueOrDefault());
            Console.WriteLine("Has Value: " + date.HasValue);
            Console.WriteLine("Value: " + date.Value);

        }

        static void NullCoalescence()
        {
            DateTime? date = null;

            DateTime date5;
            if (date != null)
                date5 = date.GetValueOrDefault();
            else
                date5 = DateTime.Today;

            Console.WriteLine("Date 5: " + date5);

            //  USING THE COALESCENCE OPERATOR
            DateTime? date6 = date ?? DateTime.Today;

            Console.WriteLine("Coalescense: " + date6);

            //Using Tertiary Operator
            DateTime? date7 = (date != null) ? date.GetValueOrDefault() : DateTime.Today.AddHours(12);
            Console.WriteLine(date7);
        }
    }
}
