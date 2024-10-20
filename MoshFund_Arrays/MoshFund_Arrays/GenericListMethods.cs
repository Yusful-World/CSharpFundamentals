using System;
using System.Collections.Generic;
using System.Linq;

namespace MoshFund_Arrays_Lists
{
    public class GenericListMethods
    {
        List<int> numbers = new List<int>() { 1, 2, 4, 5, 6, 4 };
        public void AddMethod()
        {
            numbers.Add(1);
            numbers.AddRange(new int[3] { 3, 6, 9 });

            foreach (var number in numbers)
                Console.WriteLine(number);
            Console.WriteLine();
        }
        public void IndexMethod()
        {
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Last index of 1: " + numbers.LastIndexOf(1));
        }
        public void RemoveMethod()
        {
            numbers.Remove(1);
            // to remove all appearances of 1
            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1) 
                    numbers.RemoveAt(i); // numbers.Remove(numbers[i];
            }
            foreach (var number in numbers)
                Console.WriteLine(number);
            Console.WriteLine();
        }
        public int CountMethod()
        {
            numbers.Count();
            return numbers.Count();
        }
        public void ClearMethod()
        {
            numbers.Clear();
            Console.WriteLine("Count After Clearing: " + CountMethod());
        }
    }
}
