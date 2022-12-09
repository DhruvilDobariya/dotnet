namespace ArrayClass
{
    class InitializationSDArray
    {
        static void Main(string[] args)
        {
            // Method 1:
            // defining an array
            int[] array1 = new int[5];

            //initializing an array
            array1[0] = 1;
            array1[2] = 2;
            array1[3] = 3;
            array1[4] = 4;
            array1[5] = 5;

            // Method 2:
            // initialized all at declaration time  
            int[] array2 = new int[5] { 1, 2, 3, 4, 5 };

            // Method 3:
            // declaring an array
            int[] array3;

            // initializing an array
            array3 = new int[5] { 1, 2, 3, 4, 5 };
        }
    }
}
