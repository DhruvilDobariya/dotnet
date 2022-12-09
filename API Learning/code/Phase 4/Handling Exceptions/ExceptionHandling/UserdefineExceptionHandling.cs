namespace ExceptionHandling
{
    // User defined Exception class
    // Child of Exception
    class DivByZero : Exception
    {

        // Constructor
        public DivByZero()
        {
            Console.Write("Exception has occurred : ");
        }
    }
    public class UserdefineExceptionHandling
    {
        public static void Main(string[] args)
        {
            try
            {
                double ans = Division(9, 0);
                Console.WriteLine($"The answer is : {ans}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static double Division(double numerator, double denominator)
        {
            // throw exception when denominator
            // value is 0
            if (denominator == 0)
                throw new DivByZero();

            // Otherwise return the result of the division
            return numerator / denominator;
        }
    }
}
