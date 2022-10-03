using System;

namespace LoopIteration
{
    class DoWhileDemo
    {
        static void Main(string[] args)
        {
            int a = 1;

            do
            {
                Console.WriteLine(a);
                a++;
            } while (a <= 10);
        }
    }
}
