using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshInt_Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = int.TryParse("abc", out int number); 
            if (result)
                Console.WriteLine(number);
            else
            {
                Console.WriteLine("Conversion failed");
            }

            // OR 

            try
            {
                int num = int.Parse("abc");
            }
            catch
            {
                Console.WriteLine("Conversion failed");
            }
        }
        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5, 6, 7, 8));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(0, 0);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at: ({0}, {1})", point.X, point.Y);

                point.Move(null);
                Console.WriteLine("Point is at: ({0}, {1})", point.X, point.Y);
            }
            catch
            {
                Console.WriteLine("An unexpected error occured");
            }
        }
    }
}
