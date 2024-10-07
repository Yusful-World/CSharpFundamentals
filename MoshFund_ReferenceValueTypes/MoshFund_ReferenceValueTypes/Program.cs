using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshFund_ReferenceValueTypes
{
    public class DataType
    {
        private int a;
        private int b;

        public void ValueType()
        {
            a = 10;
            b = a;
            b++;
            Console.WriteLine(string.Format("a: {0} b: {1}", a, b));
        }

        public void ReferenceType()
        {
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 4;
            Console.WriteLine(string.Format("array1[0]: {0} array2[0]: {1}", array1[0], array2[0]));
        }


    }
    public class Person
    {
        public int Age;
    }

    public class Program
    {
        static void Main(string[] args)
        {
            DataType type = new DataType();
            type.ValueType();
            type.ReferenceType();

            int number = 50;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);
        }

        public static void Increment(int number)
        {
            number += 10; 
        }
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
