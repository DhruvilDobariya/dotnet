using System;

namespace ArrayClass
{
    class AccessingValueMDArray
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[2, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            // here the length of array is 8

            // Method 1:
            Console.WriteLine(array1[0, 0]);
            Console.WriteLine(array1[0, 1]);
            Console.WriteLine(array1[0, 2]);
            Console.WriteLine(array1[0, 3]);

            Console.WriteLine(array1[1, 0]);
            Console.WriteLine(array1[1, 1]);
            Console.WriteLine(array1[1, 2]);
            Console.WriteLine(array1[1, 3]);


            // Method 2:

            // using foreach

            foreach (int a in array1)
            {
                Console.WriteLine(a);
            }

            // using for
            for (int i = 0; i <= array1.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array1.GetUpperBound(1); j++)
                {
                    Console.WriteLine(array1[i, j]);
                }
            }

            // if we have 3d array then

            int[,,] array2 = new int[2, 2, 3]
            {
                { { 1, 2, 3 }, { 4, 5, 6 } },
                { { 7, 8, 9 }, { 0, 1, 2 } }
            };

            for (int i = 0; i <= array2.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array2.GetUpperBound(1); j++)
                {
                    for (int k = 0; k <= array2.GetUpperBound(2); k++)
                    {
                        Console.WriteLine(array2[i, j, k]);
                    }
                }
            }
        }
    }
}
