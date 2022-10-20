namespace ArrayClass
{
    class InitializationJDArray
    {
        static void Main(string[] args)
        {
            // Method 1:
            int[][] array1 = new int[3][];

            array1[0] = new int[2] { 1, 2 };
            array1[1] = new int[2] { 3, 4 };
            array1[2] = new int[3] { 5, 6, 7 };

            // Method 2:
            int[][] array2 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 4 },
                new int[] { 5, 6, 7 }
            };

            // Method 3:
            int[][] array3 =
            {
                new int[] { 1, 2 },
                new int[] { 3, 4 },
                new int[] { 5, 6, 7 }
            };

            // Multidimensional array in jugged array
            int[][,] array4 =
            {
                new int[2,2] { { 1, 2 }, { 3, 4 } },
                new int[2,3] { { 1, 2, 3 }, { 4, 5, 6 } }
            };

        }
    }
}
