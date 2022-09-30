using System;

namespace DecisionMaking
{
    class IfElseLadderDemo
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;

            if (a > b && a > c)
            {
                Console.WriteLine(a + " is grater then " + b + " and " + c);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b + " is grater then " + a + " and " + c);
            }
            else
            {
                Console.WriteLine(c + " is grater then " + a + " and " + b);
            }
        }
    }
}
