using System;

namespace ArrayClass
{
    class AccessingValueJDArray
    {
        static void Main(string[] args)
        {
            int[][] array1 =
            {
                new int[] { 1, 2 },
                new int[] { 3, 4 },
                new int[] { 5, 6, 7 }
            };

            int[][,] array2 =
            {
                new int[,] { { 1, 2 }, { 3, 4 } },
                new int[,] { { 1, 2, 3 }, { 4, 5, 0 } }
            };

            // Method 1:
            Console.WriteLine(array1[0][0]);
            Console.WriteLine(array1[1][0]);
            Console.WriteLine(array1[2][1]);

            Console.WriteLine(array2[0][0, 1]);
            Console.WriteLine(array2[1][1, 0]);

            // Method 2:
            foreach (int[] a1 in array1)
            {
                foreach (int a2 in a1)
                {
                    Console.WriteLine(a2);
                }
            }

            foreach (int[,] a3 in array2)
            {
                foreach (int a4 in a3)
                {
                    Console.WriteLine(a4);
                }
            }
        }
    }
}
