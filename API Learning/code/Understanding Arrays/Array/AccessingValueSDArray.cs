using System;

namespace Array
{
    class AccessingValueSDArray
    {
        static void Main(string args[])
        {
            int[] a = new int[5] { 1, 2, 3, 4, 5 };

            // Useing index of array
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            Console.WriteLine(a[3]);
            Console.WriteLine(a[4]);
            Console.WriteLine(a[5]);

            //using foreach loop
            foreach (int element in a)
            {
                Console.WriteLine(element);
            }
        }
    }
}
