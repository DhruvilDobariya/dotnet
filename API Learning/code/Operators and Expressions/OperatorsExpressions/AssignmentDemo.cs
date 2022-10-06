using System;

namespace OperatorsExpressions
{
    class AssignmentDemo
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            int c = a + b;
            Console.WriteLine(c);

            c += a;
            Console.WriteLine(c);

            c -= a;
            Console.WriteLine(c);

            c *= a;
            Console.WriteLine(c);

            c /= a;
            Console.WriteLine(c);

            c %= a;
            Console.WriteLine(c);

            c <<= 2;
            Console.WriteLine(c);

            c >>= 2;
            Console.WriteLine(c);

            c &= a;
            Console.WriteLine(c);

            c |= a;
            Console.WriteLine(c);

            c ^= a;
            Console.WriteLine(c);

        }
    }
}
