namespace Array
{
    class InitializationMDarray
    {
        static void Main(string[] args)
        {
            // Two dimensional array
            // Method 1:
            int[,] array1 = new int[,] 
            { 
                { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 } 
            };

            // Method 2:
            int[,] array2 = new int[5, 2] 
            { 
                { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 } 
            };


            // Three dimensional array
            // Method 1: 
            int[,,] array3 = new int[,,] 
            { 
                { { 1, 2 }, { 3, 4 } }, 
                { { 5, 6 }, { 7, 8 } }, 
                { { 9, 10 }, { 1, 2 } } 
            };

            // Method 2:
            int[,,] array4 = new int[3, 2, 2] 
            {
                { { 1, 2 }, { 3, 4 } }, 
                { { 5, 6 }, { 7, 8 } }, 
                { { 9, 10 }, { 1, 2 } } 
            };
        }
    }
}
