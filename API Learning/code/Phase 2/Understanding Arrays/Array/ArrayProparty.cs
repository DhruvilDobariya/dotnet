using System;

namespace ArrayClass
{
    class ArrayProparty
    {
        static void Main(string[] args)
        {
            int[] a = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine(a.Length); // length of array
            Console.WriteLine(a.IsFixedSize); // if fixed then return true oherwise return false
            Console.WriteLine(a.IsReadOnly); // if readonly then return true otherwise return false
            Console.WriteLine(a.LongLength); // length of array in long
            Console.WriteLine(a.Rank); // dimension of array
        }
    }
}
