using System;

namespace ArrayClass
{
    class ArrayMethod
    {
        static void Main(string[] args)
        {
            // array is a mutable, so it change in it self.
            int[] a = new int[5] { 1, 2, 3, 4, 5 };
            int[] b = new int[5];

            Console.WriteLine(a.GetLength(0)); // param : dimension, return : length of array
            Console.WriteLine(a.GetLongLength(0)); // param : dimesion, return : length of array in long
            Console.WriteLine(a.GetLowerBound(0)); // param : dimesion, return : lowest index of array
            Console.WriteLine(a.GetUpperBound(0)); // param : dimesion, return : gratest index of array

            Console.WriteLine(a.GetType()); // type of array
            Console.WriteLine(a.ToString()); // type of array in string

            Array.Copy(a, b, a.Length); // param : first is source array, seconde is destination array and third is length of source array, copy one array to second array
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }

            // For one dimensional array
            a.SetValue(7, 4); // param : first is object which you want to set, second is index of object where you want to set
            Console.WriteLine(a.GetValue(4)); // param : index of element which you want to get, return : value of index which you specified
            Console.WriteLine(Array.IndexOf(a, 1)); // param : fisrt is array name and second is element which you want to position of get
            Array.Reverse(a); // param : name of array, It create reverse array 
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Array.Sort(a); // param : name of array
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }

            int[] a2 = new int[7];

            Console.WriteLine();
            a.CopyTo(a2, 2); // param : first is a destination array and second is index no where you want to start pasting the array which you copy, copy the array form one array to second array
            foreach (int i in a2)
            {
                Console.Write(i + " ");
            }

            int[] a4 = Array.Empty<int>(); // return empty array.

            Console.WriteLine();
            Array.Clear(a, 0, 3); // param : first is a array which you want to clear, second is index where you want to start to clear array and third is ending index where you waant to end clear, clear array
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }

        }
    }
}
