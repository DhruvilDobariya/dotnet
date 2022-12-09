using System;

namespace OperatorsExpressions
{
    class BitwiseDemo
    {
        static void Main(string[] args)
        {
            int a = 60;
            int b = 13;

            Console.WriteLine(a & b);
            Console.WriteLine(a | b);
            Console.WriteLine(a ^ b);
            Console.WriteLine(~a);
            Console.WriteLine(a << 2);
            Console.WriteLine(a >> 2);

        }
    }
}
