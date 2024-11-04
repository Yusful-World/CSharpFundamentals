using System;

namespace MoshAdvance_Generics
{
    //T : IComparable - applying Generics to Interface
    //T : class - applying to reference type
    //T : new() - an object with a default parameter
    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public T Max(T a, T b) 
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething()
        {
            var obj = (new T());
        }

    }
}
