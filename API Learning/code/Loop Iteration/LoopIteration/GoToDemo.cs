using System;

namespace LoopIteration
{
    class GoToDemo
    {
        static void Main(string[] args)
        {
        ineligible:
            Console.WriteLine("You are ineligible for voting!");

            Console.Write("Enter your age : ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a < 18)
            {
                goto ineligible;
            }
            else
            {
                Console.WriteLine("You are eligible for voting.");
            }
        }
    }
}
