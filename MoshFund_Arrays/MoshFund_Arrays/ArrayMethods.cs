using System;

namespace MoshFund_Arrays_Lists
{
    public class ArrayMethods
    {
        public int[] numbers = { 1, 3, 4, 6, 2, 5, 6, 3, 6, 3 };
        public void ArrayLength()
        {
            var arrayLength = numbers.Length;
            Console.WriteLine("Array length: " + arrayLength);
        }
        public void ArrayIndex()
        {
            Console.WriteLine("Array index: " + Array.IndexOf(numbers, 6));
        }
        public void ArrayClear()
        {
            Array.Clear(numbers, 0, 3);
            Console.WriteLine("Effect of Clear Method: ");
            foreach (var n in numbers)
                Console.WriteLine(n);
        }
        public int[] CopyArray()
        {
            var newArray = new int[5];
            Array.Copy(numbers, 0, newArray, 0, 5);
            Console.Write("Coping Array: ");
            foreach (var n in newArray)
                Console.WriteLine(n);
            return newArray;
        }
        public void SortArray()
        {
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort: ");
            foreach (var n in numbers)
                Console.WriteLine(n);
        }
        public void ReverseArray()
        {
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse Method");
            foreach(var n in numbers)
                Console.WriteLine(n);
        }
        public void ResizeArray()
        {
            var newArray = new int[5];
            Array.Copy(numbers, 0, newArray, 0, 5);

            Array.Resize(ref newArray, 8);
            Array.Copy(numbers, 6, newArray, 6, 2);
            foreach (var n in newArray)
                Console.WriteLine(n);

        }
    }
}
