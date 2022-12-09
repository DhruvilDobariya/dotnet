using System;

namespace DecisionMaking
{
    class NestedIFDemo
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;

            if (a < b)
            {
                if (c < b)
                {
                    Console.WriteLine(b + " is grater then " + a + " and " + c);
                }
                else
                {
                    Console.WriteLine(c + " is grater then " + a + " and " + b);
                }
            }
            else
            {
                if (c < a)
                {
                    Console.WriteLine(a + " is grater then " + b + " and " + c);
                }
                else
                {
                    Console.WriteLine(c + " is grater then " + a + " and " + b);
                }
            }
        }
    }
}
