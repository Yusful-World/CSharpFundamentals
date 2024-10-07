using System;

namespace MoshFund_NonPrimitiveDataType
{
    public partial class Program
    {
        public class IntroToArrays
        {
            int[] array = new int[3];
            bool[] boolArray = new bool[3];
            public void ArrayIndex()
            {
                array[0] = 1;

                Console.WriteLine(array[0]);
                Console.WriteLine(array[1]);
                Console.WriteLine(array[2]);
                Console.WriteLine();
                
                boolArray[0] = true;

                Console.WriteLine(boolArray[0]);
                Console.WriteLine(boolArray[1]);
                Console.WriteLine(boolArray[2]);
                Console.WriteLine();

                var stringArray = new string[3] { "Abdullahi", "Yusuf", "Oshioriamhe" }; 

            }
        }
    }
}
