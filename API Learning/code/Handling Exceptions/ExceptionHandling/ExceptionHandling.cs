namespace ExceptionHandling
{
    public class ExceptionHandling
    {
        public static void Main(string[] args)
        {
            int[] arr = { 19, 0, 75, 52 };

            try
            {

                // Try to generate an exception
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] / arr[i + 1]);
                }
            }

            // Catch block for invalid array access
            catch (IndexOutOfRangeException e)
            {

                Console.WriteLine($"An Exception has occurred : {e.Message}");
            }

            // Catch block for attempt to divide by zero
            catch (DivideByZeroException e)
            {

                Console.WriteLine($"An Exception has occurred : {e.Message}");
            }

            // Catch block for value being out of range
            catch (ArgumentOutOfRangeException e)
            {

                Console.WriteLine($"An Exception has occurred : {e.Message}");
            }

            // Finally block
            // Will execute irrespective of the above catch blocks
            finally
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(" {0}", arr[i]);
                }
            }
        }
    }
}
