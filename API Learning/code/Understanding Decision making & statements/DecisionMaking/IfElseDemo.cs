using System;

namespace DecisionMaking
{
    class IfElseDemo
    {
        static void Main(string[] args)
        {
            int a = 21;
            if (a % 2 == 0)
            {
                Console.WriteLine(a + " is a even");
            }
            else
            {
                Console.WriteLine(a + " is a odd");
            }
        }
    }
}
