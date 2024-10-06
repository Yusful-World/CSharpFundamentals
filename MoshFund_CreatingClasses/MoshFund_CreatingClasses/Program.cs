using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoshFund_CreatingClasses.Math;

namespace MoshFund_CreatingClasses
{

    public class Program
    {
        static void Main(string[] args)
        {
            Person yusuf = new Person();
            yusuf.Title = "Mr.";
            yusuf.FirstName = "Yusuf";
            yusuf.LastName = "Abdullahi";
            yusuf.Origin = "Etsako West LGA, Edo State, Nigeria.";
            yusuf.DateOfBirth = new DateTime(2000, 04, 17);
            yusuf.Introduce();
            int MyAge = yusuf.Age();
            Console.WriteLine("I am " + MyAge + " years old");


            Calculator calculator = new Calculator();
            calculator.Add(3, 5);
        }
    }
}
