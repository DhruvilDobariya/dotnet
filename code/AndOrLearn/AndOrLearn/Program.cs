namespace AndOrLearn
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OldSyntax(20);
            NewSyntax(20);
        }
        public static void OldSyntax(int n)
        {
            if ((n >= 10 && n <= 20) || n == 21 || n == 4)
            {
                Console.WriteLine($"{n} is acceptable number");
            }
        }
        public static void NewSyntax(int n)
        {
            // "and" and "or" is only used with "is".
            if ((n is (>= 10 and <= 20)) || (n is (21 or 4)))
            {
                Console.WriteLine($"{n} is acceptable number");
            }
        }
    }
}
